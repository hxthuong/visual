using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyPhotoAlbum;

namespace MyPhotoControls
{
    public partial class PhotoEditDialog : MyPhotoControls.BaseEditDialog
    {
        protected PhotoEditDialog()
        {
            InitializeComponent();
        }
        private Photo _photo;
        private Photo Photo
        { get { return _photo; } }
        private AlbumManager _manager = null;
        private AlbumManager Manager
        { get { return _manager; } }
        private void InitializeDialog(Photo photo)
        {
            _photo = photo;
            ResetDialog();
        }
        public PhotoEditDialog(Photo photo): this()
        {
            if (photo == null)
                throw new ArgumentNullException("The photo parameter cannotbe null");
            InitializeDialog(photo);
        }
        public PhotoEditDialog(AlbumManager mgr): this()
        {
            if (mgr == null)
                throw new ArgumentNullException("The mgr parameter cannot be null");
            _manager = mgr;
            InitializeDialog(mgr.Current);
        }
        protected override void ResetDialog()
        {
            Photo photo = Photo;
            if (photo != null)
            {
                txtPhotoFile.Text = photo.FileName;
                txtCaption.Text = photo.Caption;
                mskDateTaken.ValidatingType = typeof(CurrentDate);
                txtPhotographer.Text = photo.Photographer;
                txtNotes.Text = photo.Notes;
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                SaveSettings();
        }
        private void SaveSettings()
        {
            Photo photo = Photo;
            if (photo != null)
            {
                photo.Caption = txtCaption.Text;
                photo.Photographer = txtPhotographer.Text;
                photo.Notes = txtNotes.Text;
                // On parse error, do not set date
                try
                {
                    photo.DateTaken = DateTime.Parse(mskDateTaken.Text);
                }
                catch (FormatException) { }
            }
        }

        private void txtCaption_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !(Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c) || Char.IsControl(c));
            if (e.Handled)
                Console.Beep();
        }

        private void txtCaption_TextChanged(object sender, EventArgs e)
        {
            Text = txtCaption.Text + " - Properties";
        }
        private static class CurrentDate
        {
            public static DateTime Parse(string input)
            {
                DateTime result = DateTime.Parse(input);
                if (result > DateTime.Now)
                    throw new FormatException( "The given date is inthe future.");
                return result;
            }
        }

        private void mskDateTaken_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                DialogResult result = MessageBox.Show("The Date Taken entry is invalid or "
                                                        + "in thefuture and may be ignored."
                                                        + " Do you wish to correct this?",
                                                         "Photo Properties",
                                                          MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Question);
                e.Cancel = (result == DialogResult.Yes);
            }
        }
    }
    }
}

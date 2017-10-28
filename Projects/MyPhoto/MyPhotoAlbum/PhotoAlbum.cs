using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MyPhotoAlbum
{
    public class PhotoAlbum:Collection<Photo>,IDisposable
    {
        public enum DescriptorOption
        { FileName, Caption, DateTaken }
        private string _title;
        private DescriptorOption _descriptor;
        public PhotoAlbum()
        {
            ClearSettings();
        }
        public void Dispose()
        {
            ClearSettings();
            foreach (Photo p in this)
                p.Dispose();
        }
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                HasChanged = true;
            }
        }
        public DescriptorOption PhotoDescriptor
        {
            get { return _descriptor; }
            set
            {
                _descriptor = value;
                HasChanged = true;
            }
        }
        public string GetDescription(Photo photo)
        {
            switch (PhotoDescriptor)
            {
                case DescriptorOption.Caption:
                    return photo.Caption;
                case DescriptorOption.DateTaken:
                    return photo.DateTaken.ToShortDateString();
                case DescriptorOption.FileName:
                    return photo.FileName;
            }
            throw new ArgumentException( "Unrecognized photo descriptor option.");
        }
        public string GetDescription(int index)
        {
            return GetDescription(this[index]);
        }
        private string _pwd;
        public string Password
        {
            get { return _pwd; }
            set { _pwd = value; }
        }
        private bool _hasChanged = false;
        public bool HasChanged
        {
            get
            {
                if (_hasChanged) return true;
                foreach (Photo p in this)
                    if (p.HasChanged) return true;
                return false;
            }
            internal set
            {
                _hasChanged = value;
                if (value == false)
                {
                    foreach (Photo p in this)
                        p.HasChanged = false;
                }
            }
        }
        public Photo Add(string fileName)
        {
            Photo p = new Photo(fileName);
            base.Add(p);
            return p;
        }
        protected override void ClearItems()
        {
            if (Count > 0)
            {
                Dispose();
                base.ClearItems();
                HasChanged = true;
            }
        }
        protected override void InsertItem(int index, Photo item)
        {
            base.InsertItem(index, item);
            HasChanged = true;
        }
        protected override void RemoveItem(int index)
        {
            Items[index].Dispose();
            base.RemoveItem(index);
            HasChanged = true;
        }
        protected override void SetItem(int index, Photo item)
        {
            base.SetItem(index, item);
            HasChanged = true;
        }
        public void Dispose()
        {
            foreach (Photo p in this)
                p.Dispose();
        }
    }
}

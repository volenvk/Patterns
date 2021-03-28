namespace BuildPatterns.Prototype.Models
{
    using System;
    using System.Collections.Generic;

    public class PhotoAlbum
    {
        public List<Picture> Photos { get; }

        public PhotoAlbum()
        {
            Photos = new List<Picture>();
        }

        public void Add(Picture picture)
        {
            if (picture == null)
                throw new ArgumentNullException(nameof(picture));
                
            Photos.Add(picture);
        }
    }
}
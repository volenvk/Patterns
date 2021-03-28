namespace BuildPatterns.Prototype.Models
{
    using System;

    public class Image
    {
    }
    
    public abstract class Picture
    {
        public Image Image { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        protected Picture(Image image, int width, int height)
        {
            Image = image ?? throw new ArgumentNullException(nameof(image));
            Width = width;
            Height = height;
        }
        
        protected Picture(Picture picture)
        {
            if (picture == null)
                throw new ArgumentNullException(nameof(picture));
            
            Image = picture.Image;
            Width = picture.Width;
            Height = picture.Height;
        }

        public abstract Picture Clone();
    }
}
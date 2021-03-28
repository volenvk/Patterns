namespace BuildPatterns.Prototype.Models
{
    using System;
    using System.Drawing;

    public class PhotoFrame
    {
        public Photo Photo { get; set; }
        public Color Color { get; set; }
        
        public PhotoFrame(Photo photo, Color color)
        {
            Photo = photo ?? throw new ArgumentNullException(nameof(photo));
            Color = color;
        }
    }
}
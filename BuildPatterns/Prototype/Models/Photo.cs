namespace BuildPatterns.Prototype.Models
{
    public class Photo : Picture
    {
        public Photo(Image image, int width, int height) : base(image, width, height) { }

        private Photo(Picture picture) : base(picture) { }

        public override Picture Clone()
        {
            return new Photo(this);
        }
    }
}
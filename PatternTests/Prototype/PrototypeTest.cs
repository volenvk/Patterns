using NUnit.Framework;

namespace PatternTests.Prototype
{
    using System.Drawing;
    using System.Linq;
    using BuildPatterns.Prototype.Models;

    public class PrototypeTest
    {
        [Test]
        public void TestPrototype()
        {
            var photo = new Photo(new Image(), 300, 400);
            var frame = new PhotoFrame(photo, Color.Chocolate);
            var album = new PhotoAlbum();
            
            Assert.IsTrue(photo == frame.Photo);
            
            album.Add(photo);
            album.Add(frame.Photo);
            album.Add(photo.Clone());
            album.Add(frame.Photo.Clone());
            
            photo.Height = 0;
            photo.Width = 0;
            
            Assert.AreEqual(0, photo.Height);
            Assert.AreEqual(0, photo.Width);
            Assert.AreEqual(0, frame.Photo.Height);
            Assert.AreEqual(0, frame.Photo.Width);
            
            Assert.IsTrue(album.Photos.Any());
            
            Assert.IsTrue(album.Photos.Any(p=> p.Height == 0));
            Assert.IsTrue(album.Photos.Any(p=> p.Height != 0));
            Assert.AreEqual(2, album.Photos.Where(p=> p.Height == 0).Count());
            Assert.AreEqual(2, album.Photos.Where(p=> p.Height != 0).Count());
        }
    }
}
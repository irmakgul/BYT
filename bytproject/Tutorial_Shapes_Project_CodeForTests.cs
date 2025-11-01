using NUnit.Framework;
using Tut2_s20123;

namespace Tut2_s20123_Tests
{
    [TestFixture]
    public class Tests
    {
        
        [Test]
        public void Sphere_R5_Area_Is_314_159()
        {
            IShape sphere = new Sphere(5);
            Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
        }

        [Test]
        public void Sphere_R5_Volume_Is_523_598()
        {
            IShape sphere = new Sphere(5);
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
        }

       
        [Test]
        public void Cylinder_R3_H7_Area_Is_188_495()
        {
            IShape cylinder = new Cylinder(3, 7);
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(188.495).Within(0.001));
        }

        [Test]
        public void Cylinder_R3_H7_Volume_Is_197_920()
        {
            IShape cylinder = new Cylinder(3, 7);
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(197.920).Within(0.001));
        }

        
        [Test]
        public void Rectangle_4x8_Area_Is_32()
        {
            IShape rect = new Rectangle(4, 8);
            Assert.That(rect.CalculateArea(), Is.EqualTo(32).Within(0.001));
        }

        [Test]
        public void Rectangle_4x8_Volume_Is_0()
        {
            IShape rect = new Rectangle(4, 8);
            Assert.That(rect.CalculateVolume(), Is.EqualTo(0).Within(0.0));
        }

       
        [Test]
        public void Cube_Side4_Area_Is_96()
        {
            IShape cube = new Cube(4);
            Assert.That(cube.CalculateArea(), Is.EqualTo(96).Within(0.001));
        }

        [Test]
        public void Cube_Side4_Volume_Is_64()
        {
            IShape cube = new Cube(4);
            Assert.That(cube.CalculateVolume(), Is.EqualTo(64).Within(0.001));
        }
    }
}
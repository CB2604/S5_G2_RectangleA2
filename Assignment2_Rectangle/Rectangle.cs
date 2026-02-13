using System;

namespace Assignment2_Rectangle
{
    public class Rectangle
    {
        // 2 private int
        private int length;
        private int width;

        //Default constructor
        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        //Non-default constructor for user values
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        // Get Length method
        public int GetLength()
        {
            return length;
        }

        // Set Length method
        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }

        // Get Width method
        public int GetWidth()
        {
            return width;
        }

        // Set Width method
        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        // Get Perimeter method
        public int GetPerimeter()
        {
            return 2 * (length + width);
        }

        // Get Area method
        public int GetArea()
        {
            return length * width;
        }

    }
}
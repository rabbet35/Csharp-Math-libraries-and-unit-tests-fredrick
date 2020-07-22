﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector3F
    {
        public float x, y, z;

        //constructors
        public Vector3F(float x = 0, float y = 0, float z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Vector3F(float w)
        {
            this.x = y = this.z = w;
        }
        public Vector3F(Vector3F copyVector)
        {
            this.x = copyVector.x;
            this.y = copyVector.y;
            this.z = copyVector.z;
        }

        //vector vector operators
        public static Vector3F operator + (Vector3F a, Vector3F b)
        {
            return new Vector3F(a.x+b.x,a.y+b.y,a.z+b.z);
        }
        public static Vector3F operator - (Vector3F a, Vector3F b)
        {
            return new Vector3F(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public static Vector3F operator * (Vector3F a, Vector3F b)
        {
            return new Vector3F(a.x * b.x, a.y * b.y, a.z * b.z);
        }

        //Float operators, Post
        public static Vector3F operator + (Vector3F a, float b)
        {
            return new Vector3F(a.x + b, a.y + b, a.z + b);
        }

        public static Vector3F operator - (Vector3F a, float b)
        {
            return new Vector3F(a.x - b, a.y - b, a.z - b);
        }

        public static Vector3F operator * (Vector3F a, float b)
        {
            return new Vector3F(a.x * b, a.y * b, a.z * b);
        }

        //Float operators, Pre
        public static Vector3F operator + (float b, Vector3F a)
        {
            return new Vector3F(a.x + b, a.y + b, a.z + b);
        }

        public static Vector3F operator - (float b, Vector3F a)
        {
            return new Vector3F(a.x - b, a.y - b, a.z - b);
        }

        public static Vector3F operator * (float b, Vector3F a)
        {
            return new Vector3F(a.x * b, a.y * b, a.z * b);
        }

        //funcs
        public float Dot(Vector3F vec)
        {
            return this.x * vec.x + this.y * vec.y + this.z * vec.z;
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
        }

        public void Normalize()
        {
            float length = this.Magnitude();
            if (length != 0)
            {
                this.x /= length;
                this.y /= length;
                this.z /= length;
            }
            else
            {
                this.x = this.y = this.z = 0;
            }
        }
        
        public Vector3F Cross(Vector3F vec)
        {
            return new Vector3F(this.y * vec.z - this.z * vec.y, this.z * vec.x - this.x * vec.z, this.x * vec.y - this.y * vec.x);
        }
    }
}

// GENERATED CODE
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(double4.DebuggerProxy))]
    [System.Serializable]
    public partial struct double4 : System.IEquatable<double4>, IFormattable
    {
        public double x;
        public double y;
        public double z;
        public double w;

        /// <summary>double4 zero value.</summary>
        public static readonly double4 zero;

        /// <summary>Constructs a double4 vector from four double values.</summary>
        
        public double4(double x, double y, double z, double w)
        { 
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a double4 vector from two double values and a double2 vector.</summary>
        
        public double4(double x, double y, double2 zw)
        { 
            this.x = x;
            this.y = y;
            this.z = zw.x;
            this.w = zw.y;
        }

        /// <summary>Constructs a double4 vector from a double value, a double2 vector and a double value.</summary>
        
        public double4(double x, double2 yz, double w)
        { 
            this.x = x;
            this.y = yz.x;
            this.z = yz.y;
            this.w = w;
        }

        /// <summary>Constructs a double4 vector from a double value and a double3 vector.</summary>
        
        public double4(double x, double3 yzw)
        { 
            this.x = x;
            this.y = yzw.x;
            this.z = yzw.y;
            this.w = yzw.z;
        }

        /// <summary>Constructs a double4 vector from a double2 vector and two double values.</summary>
        
        public double4(double2 xy, double z, double w)
        { 
            this.x = xy.x;
            this.y = xy.y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a double4 vector from two double2 vectors.</summary>
        
        public double4(double2 xy, double2 zw)
        { 
            this.x = xy.x;
            this.y = xy.y;
            this.z = zw.x;
            this.w = zw.y;
        }

        /// <summary>Constructs a double4 vector from a double3 vector and a double value.</summary>
        
        public double4(double3 xyz, double w)
        { 
            this.x = xyz.x;
            this.y = xyz.y;
            this.z = xyz.z;
            this.w = w;
        }

        /// <summary>Constructs a double4 vector from a double4 vector.</summary>
        
        public double4(double4 xyzw)
        { 
            this.x = xyzw.x;
            this.y = xyzw.y;
            this.z = xyzw.z;
            this.w = xyzw.w;
        }

        /// <summary>Constructs a double4 vector from a single double value by assigning it to every component.</summary>
        
        public double4(double v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }

        /// <summary>Constructs a double4 vector from a single bool value by converting it to double and assigning it to every component.</summary>
        
        public double4(bool v)
        {
            this.x = v ? 1.0 : 0.0;
            this.y = v ? 1.0 : 0.0;
            this.z = v ? 1.0 : 0.0;
            this.w = v ? 1.0 : 0.0;
        }

        /// <summary>Constructs a double4 vector from a bool4 vector by componentwise conversion.</summary>
        
        public double4(bool4 v)
        {
            this.x = v.x ? 1.0 : 0.0;
            this.y = v.y ? 1.0 : 0.0;
            this.z = v.z ? 1.0 : 0.0;
            this.w = v.w ? 1.0 : 0.0;
        }

        /// <summary>Constructs a double4 vector from a single int value by converting it to double and assigning it to every component.</summary>
        
        public double4(int v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }

        /// <summary>Constructs a double4 vector from a int4 vector by componentwise conversion.</summary>
        
        public double4(int4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }

        /// <summary>Constructs a double4 vector from a single uint value by converting it to double and assigning it to every component.</summary>
        
        public double4(uint v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }

        /// <summary>Constructs a double4 vector from a uint4 vector by componentwise conversion.</summary>
        
        public double4(uint4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }

        /// <summary>Constructs a double4 vector from a single half value by converting it to double and assigning it to every component.</summary>
        
        public double4(half v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }

        /// <summary>Constructs a double4 vector from a half4 vector by componentwise conversion.</summary>
        
        public double4(half4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }

        /// <summary>Constructs a double4 vector from a single float value by converting it to double and assigning it to every component.</summary>
        
        public double4(float v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }

        /// <summary>Constructs a double4 vector from a float4 vector by componentwise conversion.</summary>
        
        public double4(float4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }


        /// <summary>Implicitly converts a single double value to a double4 vector by assigning it to every component.</summary>
        
        public static implicit operator double4(double v) { return new double4(v); }

        /// <summary>Explicitly converts a single bool value to a double4 vector by converting it to double and assigning it to every component.</summary>
        
        public static explicit operator double4(bool v) { return new double4(v); }

        /// <summary>Explicitly converts a bool4 vector to a double4 vector by componentwise conversion.</summary>
        
        public static explicit operator double4(bool4 v) { return new double4(v); }

        /// <summary>Implicitly converts a single int value to a double4 vector by converting it to double and assigning it to every component.</summary>
        
        public static implicit operator double4(int v) { return new double4(v); }

        /// <summary>Implicitly converts a int4 vector to a double4 vector by componentwise conversion.</summary>
        
        public static implicit operator double4(int4 v) { return new double4(v); }

        /// <summary>Implicitly converts a single uint value to a double4 vector by converting it to double and assigning it to every component.</summary>
        
        public static implicit operator double4(uint v) { return new double4(v); }

        /// <summary>Implicitly converts a uint4 vector to a double4 vector by componentwise conversion.</summary>
        
        public static implicit operator double4(uint4 v) { return new double4(v); }

        /// <summary>Implicitly converts a single half value to a double4 vector by converting it to double and assigning it to every component.</summary>
        
        public static implicit operator double4(half v) { return new double4(v); }

        /// <summary>Implicitly converts a half4 vector to a double4 vector by componentwise conversion.</summary>
        
        public static implicit operator double4(half4 v) { return new double4(v); }

        /// <summary>Implicitly converts a single float value to a double4 vector by converting it to double and assigning it to every component.</summary>
        
        public static implicit operator double4(float v) { return new double4(v); }

        /// <summary>Implicitly converts a float4 vector to a double4 vector by componentwise conversion.</summary>
        
        public static implicit operator double4(float4 v) { return new double4(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two double4 vectors.</summary>
        
        public static double4 operator * (double4 lhs, double4 rhs) { return new double4 (lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w); }

        /// <summary>Returns the result of a componentwise multiplication operation on a double4 vector and a double value.</summary>
        
        public static double4 operator * (double4 lhs, double rhs) { return new double4 (lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a double value and a double4 vector.</summary>
        
        public static double4 operator * (double lhs, double4 rhs) { return new double4 (lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w); }


        /// <summary>Returns the result of a componentwise addition operation on two double4 vectors.</summary>
        
        public static double4 operator + (double4 lhs, double4 rhs) { return new double4 (lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w); }

        /// <summary>Returns the result of a componentwise addition operation on a double4 vector and a double value.</summary>
        
        public static double4 operator + (double4 lhs, double rhs) { return new double4 (lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a double value and a double4 vector.</summary>
        
        public static double4 operator + (double lhs, double4 rhs) { return new double4 (lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w); }


        /// <summary>Returns the result of a componentwise subtraction operation on two double4 vectors.</summary>
        
        public static double4 operator - (double4 lhs, double4 rhs) { return new double4 (lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w); }

        /// <summary>Returns the result of a componentwise subtraction operation on a double4 vector and a double value.</summary>
        
        public static double4 operator - (double4 lhs, double rhs) { return new double4 (lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a double value and a double4 vector.</summary>
        
        public static double4 operator - (double lhs, double4 rhs) { return new double4 (lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w); }


        /// <summary>Returns the result of a componentwise division operation on two double4 vectors.</summary>
        
        public static double4 operator / (double4 lhs, double4 rhs) { return new double4 (lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w); }

        /// <summary>Returns the result of a componentwise division operation on a double4 vector and a double value.</summary>
        
        public static double4 operator / (double4 lhs, double rhs) { return new double4 (lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a double value and a double4 vector.</summary>
        
        public static double4 operator / (double lhs, double4 rhs) { return new double4 (lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w); }


        /// <summary>Returns the result of a componentwise modulus operation on two double4 vectors.</summary>
        
        public static double4 operator % (double4 lhs, double4 rhs) { return new double4 (lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w); }

        /// <summary>Returns the result of a componentwise modulus operation on a double4 vector and a double value.</summary>
        
        public static double4 operator % (double4 lhs, double rhs) { return new double4 (lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a double value and a double4 vector.</summary>
        
        public static double4 operator % (double lhs, double4 rhs) { return new double4 (lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w); }


        /// <summary>Returns the result of a componentwise increment operation on a double4 vector.</summary>
        
        public static double4 operator ++ (double4 val) { return new double4 (++val.x, ++val.y, ++val.z, ++val.w); }


        /// <summary>Returns the result of a componentwise decrement operation on a double4 vector.</summary>
        
        public static double4 operator -- (double4 val) { return new double4 (--val.x, --val.y, --val.z, --val.w); }


        /// <summary>Returns the result of a componentwise less than operation on two double4 vectors.</summary>
        
        public static bool4 operator < (double4 lhs, double4 rhs) { return new bool4 (lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w); }

        /// <summary>Returns the result of a componentwise less than operation on a double4 vector and a double value.</summary>
        
        public static bool4 operator < (double4 lhs, double rhs) { return new bool4 (lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a double value and a double4 vector.</summary>
        
        public static bool4 operator < (double lhs, double4 rhs) { return new bool4 (lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w); }


        /// <summary>Returns the result of a componentwise less or equal operation on two double4 vectors.</summary>
        
        public static bool4 operator <= (double4 lhs, double4 rhs) { return new bool4 (lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w); }

        /// <summary>Returns the result of a componentwise less or equal operation on a double4 vector and a double value.</summary>
        
        public static bool4 operator <= (double4 lhs, double rhs) { return new bool4 (lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a double value and a double4 vector.</summary>
        
        public static bool4 operator <= (double lhs, double4 rhs) { return new bool4 (lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w); }


        /// <summary>Returns the result of a componentwise greater than operation on two double4 vectors.</summary>
        
        public static bool4 operator > (double4 lhs, double4 rhs) { return new bool4 (lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w); }

        /// <summary>Returns the result of a componentwise greater than operation on a double4 vector and a double value.</summary>
        
        public static bool4 operator > (double4 lhs, double rhs) { return new bool4 (lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a double value and a double4 vector.</summary>
        
        public static bool4 operator > (double lhs, double4 rhs) { return new bool4 (lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two double4 vectors.</summary>
        
        public static bool4 operator >= (double4 lhs, double4 rhs) { return new bool4 (lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a double4 vector and a double value.</summary>
        
        public static bool4 operator >= (double4 lhs, double rhs) { return new bool4 (lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a double value and a double4 vector.</summary>
        
        public static bool4 operator >= (double lhs, double4 rhs) { return new bool4 (lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w); }


        /// <summary>Returns the result of a componentwise unary minus operation on a double4 vector.</summary>
        
        public static double4 operator - (double4 val) { return new double4 (-val.x, -val.y, -val.z, -val.w); }


        /// <summary>Returns the result of a componentwise unary plus operation on a double4 vector.</summary>
        
        public static double4 operator + (double4 val) { return new double4 (+val.x, +val.y, +val.z, +val.w); }


        /// <summary>Returns the result of a componentwise equality operation on two double4 vectors.</summary>
        
        public static bool4 operator == (double4 lhs, double4 rhs) { return new bool4 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w); }

        /// <summary>Returns the result of a componentwise equality operation on a double4 vector and a double value.</summary>
        
        public static bool4 operator == (double4 lhs, double rhs) { return new bool4 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a double value and a double4 vector.</summary>
        
        public static bool4 operator == (double lhs, double4 rhs) { return new bool4 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w); }


        /// <summary>Returns the result of a componentwise not equal operation on two double4 vectors.</summary>
        
        public static bool4 operator != (double4 lhs, double4 rhs) { return new bool4 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w); }

        /// <summary>Returns the result of a componentwise not equal operation on a double4 vector and a double value.</summary>
        
        public static bool4 operator != (double4 lhs, double rhs) { return new bool4 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a double value and a double4 vector.</summary>
        
        public static bool4 operator != (double lhs, double4 rhs) { return new bool4 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w); }




        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxxx
        {
            
            get { return new double4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxxy
        {
            
            get { return new double4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxxz
        {
            
            get { return new double4(x, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxxw
        {
            
            get { return new double4(x, x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxyx
        {
            
            get { return new double4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxyy
        {
            
            get { return new double4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxyz
        {
            
            get { return new double4(x, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxyw
        {
            
            get { return new double4(x, x, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxzx
        {
            
            get { return new double4(x, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxzy
        {
            
            get { return new double4(x, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxzz
        {
            
            get { return new double4(x, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxzw
        {
            
            get { return new double4(x, x, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxwx
        {
            
            get { return new double4(x, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxwy
        {
            
            get { return new double4(x, x, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxwz
        {
            
            get { return new double4(x, x, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxww
        {
            
            get { return new double4(x, x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyxx
        {
            
            get { return new double4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyxy
        {
            
            get { return new double4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyxz
        {
            
            get { return new double4(x, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyxw
        {
            
            get { return new double4(x, y, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyyx
        {
            
            get { return new double4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyyy
        {
            
            get { return new double4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyyz
        {
            
            get { return new double4(x, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyyw
        {
            
            get { return new double4(x, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyzx
        {
            
            get { return new double4(x, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyzy
        {
            
            get { return new double4(x, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyzz
        {
            
            get { return new double4(x, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyzw
        {
            
            get { return new double4(x, y, z, w); }
            
            set { x = value.x; y = value.y; z = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xywx
        {
            
            get { return new double4(x, y, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xywy
        {
            
            get { return new double4(x, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xywz
        {
            
            get { return new double4(x, y, w, z); }
            
            set { x = value.x; y = value.y; w = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyww
        {
            
            get { return new double4(x, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xzxx
        {
            
            get { return new double4(x, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xzxy
        {
            
            get { return new double4(x, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xzxz
        {
            
            get { return new double4(x, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xzxw
        {
            
            get { return new double4(x, z, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xzyx
        {
            
            get { return new double4(x, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xzyy
        {
            
            get { return new double4(x, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xzyz
        {
            
            get { return new double4(x, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xzyw
        {
            
            get { return new double4(x, z, y, w); }
            
            set { x = value.x; z = value.y; y = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xzzx
        {
            
            get { return new double4(x, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xzzy
        {
            
            get { return new double4(x, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xzzz
        {
            
            get { return new double4(x, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xzzw
        {
            
            get { return new double4(x, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xzwx
        {
            
            get { return new double4(x, z, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xzwy
        {
            
            get { return new double4(x, z, w, y); }
            
            set { x = value.x; z = value.y; w = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xzwz
        {
            
            get { return new double4(x, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xzww
        {
            
            get { return new double4(x, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xwxx
        {
            
            get { return new double4(x, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xwxy
        {
            
            get { return new double4(x, w, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xwxz
        {
            
            get { return new double4(x, w, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xwxw
        {
            
            get { return new double4(x, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xwyx
        {
            
            get { return new double4(x, w, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xwyy
        {
            
            get { return new double4(x, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xwyz
        {
            
            get { return new double4(x, w, y, z); }
            
            set { x = value.x; w = value.y; y = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xwyw
        {
            
            get { return new double4(x, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xwzx
        {
            
            get { return new double4(x, w, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xwzy
        {
            
            get { return new double4(x, w, z, y); }
            
            set { x = value.x; w = value.y; z = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xwzz
        {
            
            get { return new double4(x, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xwzw
        {
            
            get { return new double4(x, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xwwx
        {
            
            get { return new double4(x, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xwwy
        {
            
            get { return new double4(x, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xwwz
        {
            
            get { return new double4(x, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xwww
        {
            
            get { return new double4(x, w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxxx
        {
            
            get { return new double4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxxy
        {
            
            get { return new double4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxxz
        {
            
            get { return new double4(y, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxxw
        {
            
            get { return new double4(y, x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxyx
        {
            
            get { return new double4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxyy
        {
            
            get { return new double4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxyz
        {
            
            get { return new double4(y, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxyw
        {
            
            get { return new double4(y, x, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxzx
        {
            
            get { return new double4(y, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxzy
        {
            
            get { return new double4(y, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxzz
        {
            
            get { return new double4(y, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxzw
        {
            
            get { return new double4(y, x, z, w); }
            
            set { y = value.x; x = value.y; z = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxwx
        {
            
            get { return new double4(y, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxwy
        {
            
            get { return new double4(y, x, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxwz
        {
            
            get { return new double4(y, x, w, z); }
            
            set { y = value.x; x = value.y; w = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxww
        {
            
            get { return new double4(y, x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyxx
        {
            
            get { return new double4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyxy
        {
            
            get { return new double4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyxz
        {
            
            get { return new double4(y, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyxw
        {
            
            get { return new double4(y, y, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyyx
        {
            
            get { return new double4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyyy
        {
            
            get { return new double4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyyz
        {
            
            get { return new double4(y, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyyw
        {
            
            get { return new double4(y, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyzx
        {
            
            get { return new double4(y, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyzy
        {
            
            get { return new double4(y, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyzz
        {
            
            get { return new double4(y, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyzw
        {
            
            get { return new double4(y, y, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yywx
        {
            
            get { return new double4(y, y, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yywy
        {
            
            get { return new double4(y, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yywz
        {
            
            get { return new double4(y, y, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyww
        {
            
            get { return new double4(y, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yzxx
        {
            
            get { return new double4(y, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yzxy
        {
            
            get { return new double4(y, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yzxz
        {
            
            get { return new double4(y, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yzxw
        {
            
            get { return new double4(y, z, x, w); }
            
            set { y = value.x; z = value.y; x = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yzyx
        {
            
            get { return new double4(y, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yzyy
        {
            
            get { return new double4(y, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yzyz
        {
            
            get { return new double4(y, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yzyw
        {
            
            get { return new double4(y, z, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yzzx
        {
            
            get { return new double4(y, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yzzy
        {
            
            get { return new double4(y, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yzzz
        {
            
            get { return new double4(y, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yzzw
        {
            
            get { return new double4(y, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yzwx
        {
            
            get { return new double4(y, z, w, x); }
            
            set { y = value.x; z = value.y; w = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yzwy
        {
            
            get { return new double4(y, z, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yzwz
        {
            
            get { return new double4(y, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yzww
        {
            
            get { return new double4(y, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 ywxx
        {
            
            get { return new double4(y, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 ywxy
        {
            
            get { return new double4(y, w, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 ywxz
        {
            
            get { return new double4(y, w, x, z); }
            
            set { y = value.x; w = value.y; x = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 ywxw
        {
            
            get { return new double4(y, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 ywyx
        {
            
            get { return new double4(y, w, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 ywyy
        {
            
            get { return new double4(y, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 ywyz
        {
            
            get { return new double4(y, w, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 ywyw
        {
            
            get { return new double4(y, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 ywzx
        {
            
            get { return new double4(y, w, z, x); }
            
            set { y = value.x; w = value.y; z = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 ywzy
        {
            
            get { return new double4(y, w, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 ywzz
        {
            
            get { return new double4(y, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 ywzw
        {
            
            get { return new double4(y, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 ywwx
        {
            
            get { return new double4(y, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 ywwy
        {
            
            get { return new double4(y, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 ywwz
        {
            
            get { return new double4(y, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 ywww
        {
            
            get { return new double4(y, w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zxxx
        {
            
            get { return new double4(z, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zxxy
        {
            
            get { return new double4(z, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zxxz
        {
            
            get { return new double4(z, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zxxw
        {
            
            get { return new double4(z, x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zxyx
        {
            
            get { return new double4(z, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zxyy
        {
            
            get { return new double4(z, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zxyz
        {
            
            get { return new double4(z, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zxyw
        {
            
            get { return new double4(z, x, y, w); }
            
            set { z = value.x; x = value.y; y = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zxzx
        {
            
            get { return new double4(z, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zxzy
        {
            
            get { return new double4(z, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zxzz
        {
            
            get { return new double4(z, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zxzw
        {
            
            get { return new double4(z, x, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zxwx
        {
            
            get { return new double4(z, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zxwy
        {
            
            get { return new double4(z, x, w, y); }
            
            set { z = value.x; x = value.y; w = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zxwz
        {
            
            get { return new double4(z, x, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zxww
        {
            
            get { return new double4(z, x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zyxx
        {
            
            get { return new double4(z, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zyxy
        {
            
            get { return new double4(z, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zyxz
        {
            
            get { return new double4(z, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zyxw
        {
            
            get { return new double4(z, y, x, w); }
            
            set { z = value.x; y = value.y; x = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zyyx
        {
            
            get { return new double4(z, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zyyy
        {
            
            get { return new double4(z, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zyyz
        {
            
            get { return new double4(z, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zyyw
        {
            
            get { return new double4(z, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zyzx
        {
            
            get { return new double4(z, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zyzy
        {
            
            get { return new double4(z, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zyzz
        {
            
            get { return new double4(z, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zyzw
        {
            
            get { return new double4(z, y, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zywx
        {
            
            get { return new double4(z, y, w, x); }
            
            set { z = value.x; y = value.y; w = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zywy
        {
            
            get { return new double4(z, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zywz
        {
            
            get { return new double4(z, y, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zyww
        {
            
            get { return new double4(z, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zzxx
        {
            
            get { return new double4(z, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zzxy
        {
            
            get { return new double4(z, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zzxz
        {
            
            get { return new double4(z, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zzxw
        {
            
            get { return new double4(z, z, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zzyx
        {
            
            get { return new double4(z, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zzyy
        {
            
            get { return new double4(z, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zzyz
        {
            
            get { return new double4(z, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zzyw
        {
            
            get { return new double4(z, z, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zzzx
        {
            
            get { return new double4(z, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zzzy
        {
            
            get { return new double4(z, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zzzz
        {
            
            get { return new double4(z, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zzzw
        {
            
            get { return new double4(z, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zzwx
        {
            
            get { return new double4(z, z, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zzwy
        {
            
            get { return new double4(z, z, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zzwz
        {
            
            get { return new double4(z, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zzww
        {
            
            get { return new double4(z, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zwxx
        {
            
            get { return new double4(z, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zwxy
        {
            
            get { return new double4(z, w, x, y); }
            
            set { z = value.x; w = value.y; x = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zwxz
        {
            
            get { return new double4(z, w, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zwxw
        {
            
            get { return new double4(z, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zwyx
        {
            
            get { return new double4(z, w, y, x); }
            
            set { z = value.x; w = value.y; y = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zwyy
        {
            
            get { return new double4(z, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zwyz
        {
            
            get { return new double4(z, w, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zwyw
        {
            
            get { return new double4(z, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zwzx
        {
            
            get { return new double4(z, w, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zwzy
        {
            
            get { return new double4(z, w, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zwzz
        {
            
            get { return new double4(z, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zwzw
        {
            
            get { return new double4(z, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zwwx
        {
            
            get { return new double4(z, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zwwy
        {
            
            get { return new double4(z, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zwwz
        {
            
            get { return new double4(z, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 zwww
        {
            
            get { return new double4(z, w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wxxx
        {
            
            get { return new double4(w, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wxxy
        {
            
            get { return new double4(w, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wxxz
        {
            
            get { return new double4(w, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wxxw
        {
            
            get { return new double4(w, x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wxyx
        {
            
            get { return new double4(w, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wxyy
        {
            
            get { return new double4(w, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wxyz
        {
            
            get { return new double4(w, x, y, z); }
            
            set { w = value.x; x = value.y; y = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wxyw
        {
            
            get { return new double4(w, x, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wxzx
        {
            
            get { return new double4(w, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wxzy
        {
            
            get { return new double4(w, x, z, y); }
            
            set { w = value.x; x = value.y; z = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wxzz
        {
            
            get { return new double4(w, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wxzw
        {
            
            get { return new double4(w, x, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wxwx
        {
            
            get { return new double4(w, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wxwy
        {
            
            get { return new double4(w, x, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wxwz
        {
            
            get { return new double4(w, x, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wxww
        {
            
            get { return new double4(w, x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wyxx
        {
            
            get { return new double4(w, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wyxy
        {
            
            get { return new double4(w, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wyxz
        {
            
            get { return new double4(w, y, x, z); }
            
            set { w = value.x; y = value.y; x = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wyxw
        {
            
            get { return new double4(w, y, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wyyx
        {
            
            get { return new double4(w, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wyyy
        {
            
            get { return new double4(w, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wyyz
        {
            
            get { return new double4(w, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wyyw
        {
            
            get { return new double4(w, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wyzx
        {
            
            get { return new double4(w, y, z, x); }
            
            set { w = value.x; y = value.y; z = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wyzy
        {
            
            get { return new double4(w, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wyzz
        {
            
            get { return new double4(w, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wyzw
        {
            
            get { return new double4(w, y, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wywx
        {
            
            get { return new double4(w, y, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wywy
        {
            
            get { return new double4(w, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wywz
        {
            
            get { return new double4(w, y, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wyww
        {
            
            get { return new double4(w, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wzxx
        {
            
            get { return new double4(w, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wzxy
        {
            
            get { return new double4(w, z, x, y); }
            
            set { w = value.x; z = value.y; x = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wzxz
        {
            
            get { return new double4(w, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wzxw
        {
            
            get { return new double4(w, z, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wzyx
        {
            
            get { return new double4(w, z, y, x); }
            
            set { w = value.x; z = value.y; y = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wzyy
        {
            
            get { return new double4(w, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wzyz
        {
            
            get { return new double4(w, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wzyw
        {
            
            get { return new double4(w, z, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wzzx
        {
            
            get { return new double4(w, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wzzy
        {
            
            get { return new double4(w, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wzzz
        {
            
            get { return new double4(w, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wzzw
        {
            
            get { return new double4(w, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wzwx
        {
            
            get { return new double4(w, z, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wzwy
        {
            
            get { return new double4(w, z, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wzwz
        {
            
            get { return new double4(w, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wzww
        {
            
            get { return new double4(w, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wwxx
        {
            
            get { return new double4(w, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wwxy
        {
            
            get { return new double4(w, w, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wwxz
        {
            
            get { return new double4(w, w, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wwxw
        {
            
            get { return new double4(w, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wwyx
        {
            
            get { return new double4(w, w, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wwyy
        {
            
            get { return new double4(w, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wwyz
        {
            
            get { return new double4(w, w, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wwyw
        {
            
            get { return new double4(w, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wwzx
        {
            
            get { return new double4(w, w, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wwzy
        {
            
            get { return new double4(w, w, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wwzz
        {
            
            get { return new double4(w, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wwzw
        {
            
            get { return new double4(w, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wwwx
        {
            
            get { return new double4(w, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wwwy
        {
            
            get { return new double4(w, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wwwz
        {
            
            get { return new double4(w, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 wwww
        {
            
            get { return new double4(w, w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xxx
        {
            
            get { return new double3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xxy
        {
            
            get { return new double3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xxz
        {
            
            get { return new double3(x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xxw
        {
            
            get { return new double3(x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xyx
        {
            
            get { return new double3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xyy
        {
            
            get { return new double3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xyz
        {
            
            get { return new double3(x, y, z); }
            
            set { x = value.x; y = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xyw
        {
            
            get { return new double3(x, y, w); }
            
            set { x = value.x; y = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xzx
        {
            
            get { return new double3(x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xzy
        {
            
            get { return new double3(x, z, y); }
            
            set { x = value.x; z = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xzz
        {
            
            get { return new double3(x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xzw
        {
            
            get { return new double3(x, z, w); }
            
            set { x = value.x; z = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xwx
        {
            
            get { return new double3(x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xwy
        {
            
            get { return new double3(x, w, y); }
            
            set { x = value.x; w = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xwz
        {
            
            get { return new double3(x, w, z); }
            
            set { x = value.x; w = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xww
        {
            
            get { return new double3(x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yxx
        {
            
            get { return new double3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yxy
        {
            
            get { return new double3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yxz
        {
            
            get { return new double3(y, x, z); }
            
            set { y = value.x; x = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yxw
        {
            
            get { return new double3(y, x, w); }
            
            set { y = value.x; x = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yyx
        {
            
            get { return new double3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yyy
        {
            
            get { return new double3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yyz
        {
            
            get { return new double3(y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yyw
        {
            
            get { return new double3(y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yzx
        {
            
            get { return new double3(y, z, x); }
            
            set { y = value.x; z = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yzy
        {
            
            get { return new double3(y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yzz
        {
            
            get { return new double3(y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yzw
        {
            
            get { return new double3(y, z, w); }
            
            set { y = value.x; z = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 ywx
        {
            
            get { return new double3(y, w, x); }
            
            set { y = value.x; w = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 ywy
        {
            
            get { return new double3(y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 ywz
        {
            
            get { return new double3(y, w, z); }
            
            set { y = value.x; w = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yww
        {
            
            get { return new double3(y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 zxx
        {
            
            get { return new double3(z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 zxy
        {
            
            get { return new double3(z, x, y); }
            
            set { z = value.x; x = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 zxz
        {
            
            get { return new double3(z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 zxw
        {
            
            get { return new double3(z, x, w); }
            
            set { z = value.x; x = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 zyx
        {
            
            get { return new double3(z, y, x); }
            
            set { z = value.x; y = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 zyy
        {
            
            get { return new double3(z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 zyz
        {
            
            get { return new double3(z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 zyw
        {
            
            get { return new double3(z, y, w); }
            
            set { z = value.x; y = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 zzx
        {
            
            get { return new double3(z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 zzy
        {
            
            get { return new double3(z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 zzz
        {
            
            get { return new double3(z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 zzw
        {
            
            get { return new double3(z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 zwx
        {
            
            get { return new double3(z, w, x); }
            
            set { z = value.x; w = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 zwy
        {
            
            get { return new double3(z, w, y); }
            
            set { z = value.x; w = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 zwz
        {
            
            get { return new double3(z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 zww
        {
            
            get { return new double3(z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 wxx
        {
            
            get { return new double3(w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 wxy
        {
            
            get { return new double3(w, x, y); }
            
            set { w = value.x; x = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 wxz
        {
            
            get { return new double3(w, x, z); }
            
            set { w = value.x; x = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 wxw
        {
            
            get { return new double3(w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 wyx
        {
            
            get { return new double3(w, y, x); }
            
            set { w = value.x; y = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 wyy
        {
            
            get { return new double3(w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 wyz
        {
            
            get { return new double3(w, y, z); }
            
            set { w = value.x; y = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 wyw
        {
            
            get { return new double3(w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 wzx
        {
            
            get { return new double3(w, z, x); }
            
            set { w = value.x; z = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 wzy
        {
            
            get { return new double3(w, z, y); }
            
            set { w = value.x; z = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 wzz
        {
            
            get { return new double3(w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 wzw
        {
            
            get { return new double3(w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 wwx
        {
            
            get { return new double3(w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 wwy
        {
            
            get { return new double3(w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 wwz
        {
            
            get { return new double3(w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 www
        {
            
            get { return new double3(w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 xx
        {
            
            get { return new double2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 xy
        {
            
            get { return new double2(x, y); }
            
            set { x = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 xz
        {
            
            get { return new double2(x, z); }
            
            set { x = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 xw
        {
            
            get { return new double2(x, w); }
            
            set { x = value.x; w = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 yx
        {
            
            get { return new double2(y, x); }
            
            set { y = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 yy
        {
            
            get { return new double2(y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 yz
        {
            
            get { return new double2(y, z); }
            
            set { y = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 yw
        {
            
            get { return new double2(y, w); }
            
            set { y = value.x; w = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 zx
        {
            
            get { return new double2(z, x); }
            
            set { z = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 zy
        {
            
            get { return new double2(z, y); }
            
            set { z = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 zz
        {
            
            get { return new double2(z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 zw
        {
            
            get { return new double2(z, w); }
            
            set { z = value.x; w = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 wx
        {
            
            get { return new double2(w, x); }
            
            set { w = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 wy
        {
            
            get { return new double2(w, y); }
            
            set { w = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 wz
        {
            
            get { return new double2(w, z); }
            
            set { w = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 ww
        {
            
            get { return new double2(w, w); }
        }



        /// <summary>Returns the double element at a specified index.</summary>
        unsafe public double this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (double4* array = &this) { return ((double*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (double* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the double4 is equal to a given double4, false otherwise.</summary>
        
        public bool Equals(double4 rhs) { return x == rhs.x && y == rhs.y && z == rhs.z && w == rhs.w; }

        /// <summary>Returns true if the double4 is equal to a given double4, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((double4)o); }


        /// <summary>Returns a hash code for the double4.</summary>
        
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the double4.</summary>
        
        public override string ToString()
        {
            return string.Format("double4({0}, {1}, {2}, {3})", x, y, z, w);
        }

        /// <summary>Returns a string representation of the double4 using a specified format and culture-specific format information.</summary>
        
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("double4({0}, {1}, {2}, {3})", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider), w.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public double x;
            public double y;
            public double z;
            public double w;
            public DebuggerProxy(double4 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
                w = v.w;
            }
        }

    }

    public static partial class math
    {
        /// <summary>Returns a double4 vector constructed from four double values.</summary>
        
        public static double4 double4(double x, double y, double z, double w) { return new double4(x, y, z, w); }

        /// <summary>Returns a double4 vector constructed from two double values and a double2 vector.</summary>
        
        public static double4 double4(double x, double y, double2 zw) { return new double4(x, y, zw); }

        /// <summary>Returns a double4 vector constructed from a double value, a double2 vector and a double value.</summary>
        
        public static double4 double4(double x, double2 yz, double w) { return new double4(x, yz, w); }

        /// <summary>Returns a double4 vector constructed from a double value and a double3 vector.</summary>
        
        public static double4 double4(double x, double3 yzw) { return new double4(x, yzw); }

        /// <summary>Returns a double4 vector constructed from a double2 vector and two double values.</summary>
        
        public static double4 double4(double2 xy, double z, double w) { return new double4(xy, z, w); }

        /// <summary>Returns a double4 vector constructed from two double2 vectors.</summary>
        
        public static double4 double4(double2 xy, double2 zw) { return new double4(xy, zw); }

        /// <summary>Returns a double4 vector constructed from a double3 vector and a double value.</summary>
        
        public static double4 double4(double3 xyz, double w) { return new double4(xyz, w); }

        /// <summary>Returns a double4 vector constructed from a double4 vector.</summary>
        
        public static double4 double4(double4 xyzw) { return new double4(xyzw); }

        /// <summary>Returns a double4 vector constructed from a single double value by assigning it to every component.</summary>
        
        public static double4 double4(double v) { return new double4(v); }

        /// <summary>Returns a double4 vector constructed from a single bool value by converting it to double and assigning it to every component.</summary>
        
        public static double4 double4(bool v) { return new double4(v); }

        /// <summary>Return a double4 vector constructed from a bool4 vector by componentwise conversion.</summary>
        
        public static double4 double4(bool4 v) { return new double4(v); }

        /// <summary>Returns a double4 vector constructed from a single int value by converting it to double and assigning it to every component.</summary>
        
        public static double4 double4(int v) { return new double4(v); }

        /// <summary>Return a double4 vector constructed from a int4 vector by componentwise conversion.</summary>
        
        public static double4 double4(int4 v) { return new double4(v); }

        /// <summary>Returns a double4 vector constructed from a single uint value by converting it to double and assigning it to every component.</summary>
        
        public static double4 double4(uint v) { return new double4(v); }

        /// <summary>Return a double4 vector constructed from a uint4 vector by componentwise conversion.</summary>
        
        public static double4 double4(uint4 v) { return new double4(v); }

        /// <summary>Returns a double4 vector constructed from a single half value by converting it to double and assigning it to every component.</summary>
        
        public static double4 double4(half v) { return new double4(v); }

        /// <summary>Return a double4 vector constructed from a half4 vector by componentwise conversion.</summary>
        
        public static double4 double4(half4 v) { return new double4(v); }

        /// <summary>Returns a double4 vector constructed from a single float value by converting it to double and assigning it to every component.</summary>
        
        public static double4 double4(float v) { return new double4(v); }

        /// <summary>Return a double4 vector constructed from a float4 vector by componentwise conversion.</summary>
        
        public static double4 double4(float4 v) { return new double4(v); }

        /// <summary>Returns a uint hash code of a double4 vector.</summary>
        
        public static uint hash(double4 v)
        {
            return csum(fold_to_uint(v) * uint4(0x9F1C739Bu, 0x4B1BD187u, 0x9DF50593u, 0xF18EEB85u)) + 0x9E19BFC3u;
        }

        /// <summary>
        /// Returns a uint4 vector hash code of a double4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        
        public static uint4 hashwide(double4 v)
        {
            return (fold_to_uint(v) * uint4(0x8196B06Fu, 0xD24EFA19u, 0x7D8048BBu, 0x713BD06Fu)) + 0x753AD6ADu;
        }

        /// <summary>Returns the result of specified shuffling of the components from two double4 vectors into a double value.</summary>
        
        public static double shuffle(double4 a, double4 b, ShuffleComponent x)
        {
            return select_shuffle_component(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two double4 vectors into a double2 vector.</summary>
        
        public static double2 shuffle(double4 a, double4 b, ShuffleComponent x, ShuffleComponent y)
        {
            return double2(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two double4 vectors into a double3 vector.</summary>
        
        public static double3 shuffle(double4 a, double4 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return double3(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two double4 vectors into a double4 vector.</summary>
        
        public static double4 shuffle(double4 a, double4 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return double4(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z),
                select_shuffle_component(a, b, w));
        }

        
        internal static double select_shuffle_component(double4 a, double4 b, ShuffleComponent component)
        {
            switch(component)
            {
                case ShuffleComponent.LeftX:
                    return a.x;
                case ShuffleComponent.LeftY:
                    return a.y;
                case ShuffleComponent.LeftZ:
                    return a.z;
                case ShuffleComponent.LeftW:
                    return a.w;
                case ShuffleComponent.RightX:
                    return b.x;
                case ShuffleComponent.RightY:
                    return b.y;
                case ShuffleComponent.RightZ:
                    return b.z;
                case ShuffleComponent.RightW:
                    return b.w;
                default:
                    throw new System.ArgumentException("Invalid shuffle component: " + component);
            }
        }

    }
}

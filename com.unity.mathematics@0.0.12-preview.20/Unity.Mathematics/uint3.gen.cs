// GENERATED CODE
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(uint3.DebuggerProxy))]
    [System.Serializable]
    public partial struct uint3 : System.IEquatable<uint3>, IFormattable
    {
        public uint x;
        public uint y;
        public uint z;

        /// <summary>uint3 zero value.</summary>
        public static readonly uint3 zero;

        /// <summary>Constructs a uint3 vector from three uint values.</summary>
        
        public uint3(uint x, uint y, uint z)
        { 
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>Constructs a uint3 vector from a uint value and a uint2 vector.</summary>
        
        public uint3(uint x, uint2 yz)
        { 
            this.x = x;
            this.y = yz.x;
            this.z = yz.y;
        }

        /// <summary>Constructs a uint3 vector from a uint2 vector and a uint value.</summary>
        
        public uint3(uint2 xy, uint z)
        { 
            this.x = xy.x;
            this.y = xy.y;
            this.z = z;
        }

        /// <summary>Constructs a uint3 vector from a uint3 vector.</summary>
        
        public uint3(uint3 xyz)
        { 
            this.x = xyz.x;
            this.y = xyz.y;
            this.z = xyz.z;
        }

        /// <summary>Constructs a uint3 vector from a single uint value by assigning it to every component.</summary>
        
        public uint3(uint v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }

        /// <summary>Constructs a uint3 vector from a single bool value by converting it to uint and assigning it to every component.</summary>
        
        public uint3(bool v)
        {
            this.x = v ? 1u : 0u;
            this.y = v ? 1u : 0u;
            this.z = v ? 1u : 0u;
        }

        /// <summary>Constructs a uint3 vector from a bool3 vector by componentwise conversion.</summary>
        
        public uint3(bool3 v)
        {
            this.x = v.x ? 1u : 0u;
            this.y = v.y ? 1u : 0u;
            this.z = v.z ? 1u : 0u;
        }

        /// <summary>Constructs a uint3 vector from a single int value by converting it to uint and assigning it to every component.</summary>
        
        public uint3(int v)
        {
            this.x = (uint)v;
            this.y = (uint)v;
            this.z = (uint)v;
        }

        /// <summary>Constructs a uint3 vector from a int3 vector by componentwise conversion.</summary>
        
        public uint3(int3 v)
        {
            this.x = (uint)v.x;
            this.y = (uint)v.y;
            this.z = (uint)v.z;
        }

        /// <summary>Constructs a uint3 vector from a single float value by converting it to uint and assigning it to every component.</summary>
        
        public uint3(float v)
        {
            this.x = (uint)v;
            this.y = (uint)v;
            this.z = (uint)v;
        }

        /// <summary>Constructs a uint3 vector from a float3 vector by componentwise conversion.</summary>
        
        public uint3(float3 v)
        {
            this.x = (uint)v.x;
            this.y = (uint)v.y;
            this.z = (uint)v.z;
        }

        /// <summary>Constructs a uint3 vector from a single double value by converting it to uint and assigning it to every component.</summary>
        
        public uint3(double v)
        {
            this.x = (uint)v;
            this.y = (uint)v;
            this.z = (uint)v;
        }

        /// <summary>Constructs a uint3 vector from a double3 vector by componentwise conversion.</summary>
        
        public uint3(double3 v)
        {
            this.x = (uint)v.x;
            this.y = (uint)v.y;
            this.z = (uint)v.z;
        }


        /// <summary>Implicitly converts a single uint value to a uint3 vector by assigning it to every component.</summary>
        
        public static implicit operator uint3(uint v) { return new uint3(v); }

        /// <summary>Explicitly converts a single bool value to a uint3 vector by converting it to uint and assigning it to every component.</summary>
        
        public static explicit operator uint3(bool v) { return new uint3(v); }

        /// <summary>Explicitly converts a bool3 vector to a uint3 vector by componentwise conversion.</summary>
        
        public static explicit operator uint3(bool3 v) { return new uint3(v); }

        /// <summary>Explicitly converts a single int value to a uint3 vector by converting it to uint and assigning it to every component.</summary>
        
        public static explicit operator uint3(int v) { return new uint3(v); }

        /// <summary>Explicitly converts a int3 vector to a uint3 vector by componentwise conversion.</summary>
        
        public static explicit operator uint3(int3 v) { return new uint3(v); }

        /// <summary>Explicitly converts a single float value to a uint3 vector by converting it to uint and assigning it to every component.</summary>
        
        public static explicit operator uint3(float v) { return new uint3(v); }

        /// <summary>Explicitly converts a float3 vector to a uint3 vector by componentwise conversion.</summary>
        
        public static explicit operator uint3(float3 v) { return new uint3(v); }

        /// <summary>Explicitly converts a single double value to a uint3 vector by converting it to uint and assigning it to every component.</summary>
        
        public static explicit operator uint3(double v) { return new uint3(v); }

        /// <summary>Explicitly converts a double3 vector to a uint3 vector by componentwise conversion.</summary>
        
        public static explicit operator uint3(double3 v) { return new uint3(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two uint3 vectors.</summary>
        
        public static uint3 operator * (uint3 lhs, uint3 rhs) { return new uint3 (lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z); }

        /// <summary>Returns the result of a componentwise multiplication operation on a uint3 vector and a uint value.</summary>
        
        public static uint3 operator * (uint3 lhs, uint rhs) { return new uint3 (lhs.x * rhs, lhs.y * rhs, lhs.z * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a uint value and a uint3 vector.</summary>
        
        public static uint3 operator * (uint lhs, uint3 rhs) { return new uint3 (lhs * rhs.x, lhs * rhs.y, lhs * rhs.z); }


        /// <summary>Returns the result of a componentwise addition operation on two uint3 vectors.</summary>
        
        public static uint3 operator + (uint3 lhs, uint3 rhs) { return new uint3 (lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z); }

        /// <summary>Returns the result of a componentwise addition operation on a uint3 vector and a uint value.</summary>
        
        public static uint3 operator + (uint3 lhs, uint rhs) { return new uint3 (lhs.x + rhs, lhs.y + rhs, lhs.z + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a uint value and a uint3 vector.</summary>
        
        public static uint3 operator + (uint lhs, uint3 rhs) { return new uint3 (lhs + rhs.x, lhs + rhs.y, lhs + rhs.z); }


        /// <summary>Returns the result of a componentwise subtraction operation on two uint3 vectors.</summary>
        
        public static uint3 operator - (uint3 lhs, uint3 rhs) { return new uint3 (lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z); }

        /// <summary>Returns the result of a componentwise subtraction operation on a uint3 vector and a uint value.</summary>
        
        public static uint3 operator - (uint3 lhs, uint rhs) { return new uint3 (lhs.x - rhs, lhs.y - rhs, lhs.z - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a uint value and a uint3 vector.</summary>
        
        public static uint3 operator - (uint lhs, uint3 rhs) { return new uint3 (lhs - rhs.x, lhs - rhs.y, lhs - rhs.z); }


        /// <summary>Returns the result of a componentwise division operation on two uint3 vectors.</summary>
        
        public static uint3 operator / (uint3 lhs, uint3 rhs) { return new uint3 (lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z); }

        /// <summary>Returns the result of a componentwise division operation on a uint3 vector and a uint value.</summary>
        
        public static uint3 operator / (uint3 lhs, uint rhs) { return new uint3 (lhs.x / rhs, lhs.y / rhs, lhs.z / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a uint value and a uint3 vector.</summary>
        
        public static uint3 operator / (uint lhs, uint3 rhs) { return new uint3 (lhs / rhs.x, lhs / rhs.y, lhs / rhs.z); }


        /// <summary>Returns the result of a componentwise modulus operation on two uint3 vectors.</summary>
        
        public static uint3 operator % (uint3 lhs, uint3 rhs) { return new uint3 (lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z); }

        /// <summary>Returns the result of a componentwise modulus operation on a uint3 vector and a uint value.</summary>
        
        public static uint3 operator % (uint3 lhs, uint rhs) { return new uint3 (lhs.x % rhs, lhs.y % rhs, lhs.z % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a uint value and a uint3 vector.</summary>
        
        public static uint3 operator % (uint lhs, uint3 rhs) { return new uint3 (lhs % rhs.x, lhs % rhs.y, lhs % rhs.z); }


        /// <summary>Returns the result of a componentwise increment operation on a uint3 vector.</summary>
        
        public static uint3 operator ++ (uint3 val) { return new uint3 (++val.x, ++val.y, ++val.z); }


        /// <summary>Returns the result of a componentwise decrement operation on a uint3 vector.</summary>
        
        public static uint3 operator -- (uint3 val) { return new uint3 (--val.x, --val.y, --val.z); }


        /// <summary>Returns the result of a componentwise less than operation on two uint3 vectors.</summary>
        
        public static bool3 operator < (uint3 lhs, uint3 rhs) { return new bool3 (lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z); }

        /// <summary>Returns the result of a componentwise less than operation on a uint3 vector and a uint value.</summary>
        
        public static bool3 operator < (uint3 lhs, uint rhs) { return new bool3 (lhs.x < rhs, lhs.y < rhs, lhs.z < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a uint value and a uint3 vector.</summary>
        
        public static bool3 operator < (uint lhs, uint3 rhs) { return new bool3 (lhs < rhs.x, lhs < rhs.y, lhs < rhs.z); }


        /// <summary>Returns the result of a componentwise less or equal operation on two uint3 vectors.</summary>
        
        public static bool3 operator <= (uint3 lhs, uint3 rhs) { return new bool3 (lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z); }

        /// <summary>Returns the result of a componentwise less or equal operation on a uint3 vector and a uint value.</summary>
        
        public static bool3 operator <= (uint3 lhs, uint rhs) { return new bool3 (lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a uint value and a uint3 vector.</summary>
        
        public static bool3 operator <= (uint lhs, uint3 rhs) { return new bool3 (lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z); }


        /// <summary>Returns the result of a componentwise greater than operation on two uint3 vectors.</summary>
        
        public static bool3 operator > (uint3 lhs, uint3 rhs) { return new bool3 (lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z); }

        /// <summary>Returns the result of a componentwise greater than operation on a uint3 vector and a uint value.</summary>
        
        public static bool3 operator > (uint3 lhs, uint rhs) { return new bool3 (lhs.x > rhs, lhs.y > rhs, lhs.z > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a uint value and a uint3 vector.</summary>
        
        public static bool3 operator > (uint lhs, uint3 rhs) { return new bool3 (lhs > rhs.x, lhs > rhs.y, lhs > rhs.z); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two uint3 vectors.</summary>
        
        public static bool3 operator >= (uint3 lhs, uint3 rhs) { return new bool3 (lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a uint3 vector and a uint value.</summary>
        
        public static bool3 operator >= (uint3 lhs, uint rhs) { return new bool3 (lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a uint value and a uint3 vector.</summary>
        
        public static bool3 operator >= (uint lhs, uint3 rhs) { return new bool3 (lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z); }


        /// <summary>Returns the result of a componentwise unary minus operation on a uint3 vector.</summary>
        
        public static uint3 operator - (uint3 val) { return new uint3 ((uint)-val.x, (uint)-val.y, (uint)-val.z); }


        /// <summary>Returns the result of a componentwise unary plus operation on a uint3 vector.</summary>
        
        public static uint3 operator + (uint3 val) { return new uint3 (+val.x, +val.y, +val.z); }


        /// <summary>Returns the result of a componentwise left shift operation on a uint3 vector by a number of bits specified by a single int.</summary>
        
        public static uint3 operator << (uint3 x, int n) { return new uint3 (x.x << n, x.y << n, x.z << n); }

        /// <summary>Returns the result of a componentwise right shift operation on a uint3 vector by a number of bits specified by a single int.</summary>
        
        public static uint3 operator >> (uint3 x, int n) { return new uint3 (x.x >> n, x.y >> n, x.z >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two uint3 vectors.</summary>
        
        public static bool3 operator == (uint3 lhs, uint3 rhs) { return new bool3 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z); }

        /// <summary>Returns the result of a componentwise equality operation on a uint3 vector and a uint value.</summary>
        
        public static bool3 operator == (uint3 lhs, uint rhs) { return new bool3 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a uint value and a uint3 vector.</summary>
        
        public static bool3 operator == (uint lhs, uint3 rhs) { return new bool3 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z); }


        /// <summary>Returns the result of a componentwise not equal operation on two uint3 vectors.</summary>
        
        public static bool3 operator != (uint3 lhs, uint3 rhs) { return new bool3 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z); }

        /// <summary>Returns the result of a componentwise not equal operation on a uint3 vector and a uint value.</summary>
        
        public static bool3 operator != (uint3 lhs, uint rhs) { return new bool3 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a uint value and a uint3 vector.</summary>
        
        public static bool3 operator != (uint lhs, uint3 rhs) { return new bool3 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z); }


        /// <summary>Returns the result of a componentwise bitwise not operation on a uint3 vector.</summary>
        
        public static uint3 operator ~ (uint3 val) { return new uint3 (~val.x, ~val.y, ~val.z); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two uint3 vectors.</summary>
        
        public static uint3 operator & (uint3 lhs, uint3 rhs) { return new uint3 (lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a uint3 vector and a uint value.</summary>
        
        public static uint3 operator & (uint3 lhs, uint rhs) { return new uint3 (lhs.x & rhs, lhs.y & rhs, lhs.z & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a uint value and a uint3 vector.</summary>
        
        public static uint3 operator & (uint lhs, uint3 rhs) { return new uint3 (lhs & rhs.x, lhs & rhs.y, lhs & rhs.z); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two uint3 vectors.</summary>
        
        public static uint3 operator | (uint3 lhs, uint3 rhs) { return new uint3 (lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint3 vector and a uint value.</summary>
        
        public static uint3 operator | (uint3 lhs, uint rhs) { return new uint3 (lhs.x | rhs, lhs.y | rhs, lhs.z | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint value and a uint3 vector.</summary>
        
        public static uint3 operator | (uint lhs, uint3 rhs) { return new uint3 (lhs | rhs.x, lhs | rhs.y, lhs | rhs.z); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two uint3 vectors.</summary>
        
        public static uint3 operator ^ (uint3 lhs, uint3 rhs) { return new uint3 (lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a uint3 vector and a uint value.</summary>
        
        public static uint3 operator ^ (uint3 lhs, uint rhs) { return new uint3 (lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a uint value and a uint3 vector.</summary>
        
        public static uint3 operator ^ (uint lhs, uint3 rhs) { return new uint3 (lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z); }




        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxxx
        {
            
            get { return new uint4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxxy
        {
            
            get { return new uint4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxxz
        {
            
            get { return new uint4(x, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxyx
        {
            
            get { return new uint4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxyy
        {
            
            get { return new uint4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxyz
        {
            
            get { return new uint4(x, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxzx
        {
            
            get { return new uint4(x, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxzy
        {
            
            get { return new uint4(x, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxzz
        {
            
            get { return new uint4(x, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyxx
        {
            
            get { return new uint4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyxy
        {
            
            get { return new uint4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyxz
        {
            
            get { return new uint4(x, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyyx
        {
            
            get { return new uint4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyyy
        {
            
            get { return new uint4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyyz
        {
            
            get { return new uint4(x, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyzx
        {
            
            get { return new uint4(x, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyzy
        {
            
            get { return new uint4(x, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyzz
        {
            
            get { return new uint4(x, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xzxx
        {
            
            get { return new uint4(x, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xzxy
        {
            
            get { return new uint4(x, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xzxz
        {
            
            get { return new uint4(x, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xzyx
        {
            
            get { return new uint4(x, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xzyy
        {
            
            get { return new uint4(x, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xzyz
        {
            
            get { return new uint4(x, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xzzx
        {
            
            get { return new uint4(x, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xzzy
        {
            
            get { return new uint4(x, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xzzz
        {
            
            get { return new uint4(x, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxxx
        {
            
            get { return new uint4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxxy
        {
            
            get { return new uint4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxxz
        {
            
            get { return new uint4(y, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxyx
        {
            
            get { return new uint4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxyy
        {
            
            get { return new uint4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxyz
        {
            
            get { return new uint4(y, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxzx
        {
            
            get { return new uint4(y, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxzy
        {
            
            get { return new uint4(y, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxzz
        {
            
            get { return new uint4(y, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyxx
        {
            
            get { return new uint4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyxy
        {
            
            get { return new uint4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyxz
        {
            
            get { return new uint4(y, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyyx
        {
            
            get { return new uint4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyyy
        {
            
            get { return new uint4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyyz
        {
            
            get { return new uint4(y, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyzx
        {
            
            get { return new uint4(y, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyzy
        {
            
            get { return new uint4(y, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyzz
        {
            
            get { return new uint4(y, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yzxx
        {
            
            get { return new uint4(y, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yzxy
        {
            
            get { return new uint4(y, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yzxz
        {
            
            get { return new uint4(y, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yzyx
        {
            
            get { return new uint4(y, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yzyy
        {
            
            get { return new uint4(y, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yzyz
        {
            
            get { return new uint4(y, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yzzx
        {
            
            get { return new uint4(y, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yzzy
        {
            
            get { return new uint4(y, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yzzz
        {
            
            get { return new uint4(y, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zxxx
        {
            
            get { return new uint4(z, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zxxy
        {
            
            get { return new uint4(z, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zxxz
        {
            
            get { return new uint4(z, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zxyx
        {
            
            get { return new uint4(z, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zxyy
        {
            
            get { return new uint4(z, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zxyz
        {
            
            get { return new uint4(z, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zxzx
        {
            
            get { return new uint4(z, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zxzy
        {
            
            get { return new uint4(z, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zxzz
        {
            
            get { return new uint4(z, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zyxx
        {
            
            get { return new uint4(z, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zyxy
        {
            
            get { return new uint4(z, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zyxz
        {
            
            get { return new uint4(z, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zyyx
        {
            
            get { return new uint4(z, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zyyy
        {
            
            get { return new uint4(z, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zyyz
        {
            
            get { return new uint4(z, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zyzx
        {
            
            get { return new uint4(z, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zyzy
        {
            
            get { return new uint4(z, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zyzz
        {
            
            get { return new uint4(z, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zzxx
        {
            
            get { return new uint4(z, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zzxy
        {
            
            get { return new uint4(z, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zzxz
        {
            
            get { return new uint4(z, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zzyx
        {
            
            get { return new uint4(z, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zzyy
        {
            
            get { return new uint4(z, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zzyz
        {
            
            get { return new uint4(z, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zzzx
        {
            
            get { return new uint4(z, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zzzy
        {
            
            get { return new uint4(z, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zzzz
        {
            
            get { return new uint4(z, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xxx
        {
            
            get { return new uint3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xxy
        {
            
            get { return new uint3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xxz
        {
            
            get { return new uint3(x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xyx
        {
            
            get { return new uint3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xyy
        {
            
            get { return new uint3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xyz
        {
            
            get { return new uint3(x, y, z); }
            
            set { x = value.x; y = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xzx
        {
            
            get { return new uint3(x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xzy
        {
            
            get { return new uint3(x, z, y); }
            
            set { x = value.x; z = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xzz
        {
            
            get { return new uint3(x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yxx
        {
            
            get { return new uint3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yxy
        {
            
            get { return new uint3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yxz
        {
            
            get { return new uint3(y, x, z); }
            
            set { y = value.x; x = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yyx
        {
            
            get { return new uint3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yyy
        {
            
            get { return new uint3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yyz
        {
            
            get { return new uint3(y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yzx
        {
            
            get { return new uint3(y, z, x); }
            
            set { y = value.x; z = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yzy
        {
            
            get { return new uint3(y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yzz
        {
            
            get { return new uint3(y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 zxx
        {
            
            get { return new uint3(z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 zxy
        {
            
            get { return new uint3(z, x, y); }
            
            set { z = value.x; x = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 zxz
        {
            
            get { return new uint3(z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 zyx
        {
            
            get { return new uint3(z, y, x); }
            
            set { z = value.x; y = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 zyy
        {
            
            get { return new uint3(z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 zyz
        {
            
            get { return new uint3(z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 zzx
        {
            
            get { return new uint3(z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 zzy
        {
            
            get { return new uint3(z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 zzz
        {
            
            get { return new uint3(z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 xx
        {
            
            get { return new uint2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 xy
        {
            
            get { return new uint2(x, y); }
            
            set { x = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 xz
        {
            
            get { return new uint2(x, z); }
            
            set { x = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 yx
        {
            
            get { return new uint2(y, x); }
            
            set { y = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 yy
        {
            
            get { return new uint2(y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 yz
        {
            
            get { return new uint2(y, z); }
            
            set { y = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 zx
        {
            
            get { return new uint2(z, x); }
            
            set { z = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 zy
        {
            
            get { return new uint2(z, y); }
            
            set { z = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 zz
        {
            
            get { return new uint2(z, z); }
        }



        /// <summary>Returns the uint element at a specified index.</summary>
        unsafe public uint this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (uint3* array = &this) { return ((uint*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (uint* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the uint3 is equal to a given uint3, false otherwise.</summary>
        
        public bool Equals(uint3 rhs) { return x == rhs.x && y == rhs.y && z == rhs.z; }

        /// <summary>Returns true if the uint3 is equal to a given uint3, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((uint3)o); }


        /// <summary>Returns a hash code for the uint3.</summary>
        
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the uint3.</summary>
        
        public override string ToString()
        {
            return string.Format("uint3({0}, {1}, {2})", x, y, z);
        }

        /// <summary>Returns a string representation of the uint3 using a specified format and culture-specific format information.</summary>
        
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("uint3({0}, {1}, {2})", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public uint x;
            public uint y;
            public uint z;
            public DebuggerProxy(uint3 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
            }
        }

    }

    public static partial class math
    {
        /// <summary>Returns a uint3 vector constructed from three uint values.</summary>
        
        public static uint3 uint3(uint x, uint y, uint z) { return new uint3(x, y, z); }

        /// <summary>Returns a uint3 vector constructed from a uint value and a uint2 vector.</summary>
        
        public static uint3 uint3(uint x, uint2 yz) { return new uint3(x, yz); }

        /// <summary>Returns a uint3 vector constructed from a uint2 vector and a uint value.</summary>
        
        public static uint3 uint3(uint2 xy, uint z) { return new uint3(xy, z); }

        /// <summary>Returns a uint3 vector constructed from a uint3 vector.</summary>
        
        public static uint3 uint3(uint3 xyz) { return new uint3(xyz); }

        /// <summary>Returns a uint3 vector constructed from a single uint value by assigning it to every component.</summary>
        
        public static uint3 uint3(uint v) { return new uint3(v); }

        /// <summary>Returns a uint3 vector constructed from a single bool value by converting it to uint and assigning it to every component.</summary>
        
        public static uint3 uint3(bool v) { return new uint3(v); }

        /// <summary>Return a uint3 vector constructed from a bool3 vector by componentwise conversion.</summary>
        
        public static uint3 uint3(bool3 v) { return new uint3(v); }

        /// <summary>Returns a uint3 vector constructed from a single int value by converting it to uint and assigning it to every component.</summary>
        
        public static uint3 uint3(int v) { return new uint3(v); }

        /// <summary>Return a uint3 vector constructed from a int3 vector by componentwise conversion.</summary>
        
        public static uint3 uint3(int3 v) { return new uint3(v); }

        /// <summary>Returns a uint3 vector constructed from a single float value by converting it to uint and assigning it to every component.</summary>
        
        public static uint3 uint3(float v) { return new uint3(v); }

        /// <summary>Return a uint3 vector constructed from a float3 vector by componentwise conversion.</summary>
        
        public static uint3 uint3(float3 v) { return new uint3(v); }

        /// <summary>Returns a uint3 vector constructed from a single double value by converting it to uint and assigning it to every component.</summary>
        
        public static uint3 uint3(double v) { return new uint3(v); }

        /// <summary>Return a uint3 vector constructed from a double3 vector by componentwise conversion.</summary>
        
        public static uint3 uint3(double3 v) { return new uint3(v); }

        /// <summary>Returns a uint hash code of a uint3 vector.</summary>
        
        public static uint hash(uint3 v)
        {
            return csum(v * uint3(0xCD266C89u, 0xF1852A33u, 0x77E35E77u)) + 0x863E3729u;
        }

        /// <summary>
        /// Returns a uint3 vector hash code of a uint3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        
        public static uint3 hashwide(uint3 v)
        {
            return (v * uint3(0xE191B035u, 0x68586FAFu, 0xD4DFF6D3u)) + 0xCB634F4Du;
        }

        /// <summary>Returns the result of specified shuffling of the components from two uint3 vectors into a uint value.</summary>
        
        public static uint shuffle(uint3 a, uint3 b, ShuffleComponent x)
        {
            return select_shuffle_component(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two uint3 vectors into a uint2 vector.</summary>
        
        public static uint2 shuffle(uint3 a, uint3 b, ShuffleComponent x, ShuffleComponent y)
        {
            return uint2(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two uint3 vectors into a uint3 vector.</summary>
        
        public static uint3 shuffle(uint3 a, uint3 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return uint3(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two uint3 vectors into a uint4 vector.</summary>
        
        public static uint4 shuffle(uint3 a, uint3 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return uint4(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z),
                select_shuffle_component(a, b, w));
        }

        
        internal static uint select_shuffle_component(uint3 a, uint3 b, ShuffleComponent component)
        {
            switch(component)
            {
                case ShuffleComponent.LeftX:
                    return a.x;
                case ShuffleComponent.LeftY:
                    return a.y;
                case ShuffleComponent.LeftZ:
                    return a.z;
                case ShuffleComponent.RightX:
                    return b.x;
                case ShuffleComponent.RightY:
                    return b.y;
                case ShuffleComponent.RightZ:
                    return b.z;
                default:
                    throw new System.ArgumentException("Invalid shuffle component: " + component);
            }
        }

    }
}

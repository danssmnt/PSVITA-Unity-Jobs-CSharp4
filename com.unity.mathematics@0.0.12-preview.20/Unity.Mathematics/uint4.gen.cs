// GENERATED CODE
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(uint4.DebuggerProxy))]
    [System.Serializable]
    public partial struct uint4 : System.IEquatable<uint4>, IFormattable
    {
        public uint x;
        public uint y;
        public uint z;
        public uint w;

        /// <summary>uint4 zero value.</summary>
        public static readonly uint4 zero;

        /// <summary>Constructs a uint4 vector from four uint values.</summary>
        
        public uint4(uint x, uint y, uint z, uint w)
        { 
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a uint4 vector from two uint values and a uint2 vector.</summary>
        
        public uint4(uint x, uint y, uint2 zw)
        { 
            this.x = x;
            this.y = y;
            this.z = zw.x;
            this.w = zw.y;
        }

        /// <summary>Constructs a uint4 vector from a uint value, a uint2 vector and a uint value.</summary>
        
        public uint4(uint x, uint2 yz, uint w)
        { 
            this.x = x;
            this.y = yz.x;
            this.z = yz.y;
            this.w = w;
        }

        /// <summary>Constructs a uint4 vector from a uint value and a uint3 vector.</summary>
        
        public uint4(uint x, uint3 yzw)
        { 
            this.x = x;
            this.y = yzw.x;
            this.z = yzw.y;
            this.w = yzw.z;
        }

        /// <summary>Constructs a uint4 vector from a uint2 vector and two uint values.</summary>
        
        public uint4(uint2 xy, uint z, uint w)
        { 
            this.x = xy.x;
            this.y = xy.y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a uint4 vector from two uint2 vectors.</summary>
        
        public uint4(uint2 xy, uint2 zw)
        { 
            this.x = xy.x;
            this.y = xy.y;
            this.z = zw.x;
            this.w = zw.y;
        }

        /// <summary>Constructs a uint4 vector from a uint3 vector and a uint value.</summary>
        
        public uint4(uint3 xyz, uint w)
        { 
            this.x = xyz.x;
            this.y = xyz.y;
            this.z = xyz.z;
            this.w = w;
        }

        /// <summary>Constructs a uint4 vector from a uint4 vector.</summary>
        
        public uint4(uint4 xyzw)
        { 
            this.x = xyzw.x;
            this.y = xyzw.y;
            this.z = xyzw.z;
            this.w = xyzw.w;
        }

        /// <summary>Constructs a uint4 vector from a single uint value by assigning it to every component.</summary>
        
        public uint4(uint v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }

        /// <summary>Constructs a uint4 vector from a single bool value by converting it to uint and assigning it to every component.</summary>
        
        public uint4(bool v)
        {
            this.x = v ? 1u : 0u;
            this.y = v ? 1u : 0u;
            this.z = v ? 1u : 0u;
            this.w = v ? 1u : 0u;
        }

        /// <summary>Constructs a uint4 vector from a bool4 vector by componentwise conversion.</summary>
        
        public uint4(bool4 v)
        {
            this.x = v.x ? 1u : 0u;
            this.y = v.y ? 1u : 0u;
            this.z = v.z ? 1u : 0u;
            this.w = v.w ? 1u : 0u;
        }

        /// <summary>Constructs a uint4 vector from a single int value by converting it to uint and assigning it to every component.</summary>
        
        public uint4(int v)
        {
            this.x = (uint)v;
            this.y = (uint)v;
            this.z = (uint)v;
            this.w = (uint)v;
        }

        /// <summary>Constructs a uint4 vector from a int4 vector by componentwise conversion.</summary>
        
        public uint4(int4 v)
        {
            this.x = (uint)v.x;
            this.y = (uint)v.y;
            this.z = (uint)v.z;
            this.w = (uint)v.w;
        }

        /// <summary>Constructs a uint4 vector from a single float value by converting it to uint and assigning it to every component.</summary>
        
        public uint4(float v)
        {
            this.x = (uint)v;
            this.y = (uint)v;
            this.z = (uint)v;
            this.w = (uint)v;
        }

        /// <summary>Constructs a uint4 vector from a float4 vector by componentwise conversion.</summary>
        
        public uint4(float4 v)
        {
            this.x = (uint)v.x;
            this.y = (uint)v.y;
            this.z = (uint)v.z;
            this.w = (uint)v.w;
        }

        /// <summary>Constructs a uint4 vector from a single double value by converting it to uint and assigning it to every component.</summary>
        
        public uint4(double v)
        {
            this.x = (uint)v;
            this.y = (uint)v;
            this.z = (uint)v;
            this.w = (uint)v;
        }

        /// <summary>Constructs a uint4 vector from a double4 vector by componentwise conversion.</summary>
        
        public uint4(double4 v)
        {
            this.x = (uint)v.x;
            this.y = (uint)v.y;
            this.z = (uint)v.z;
            this.w = (uint)v.w;
        }


        /// <summary>Implicitly converts a single uint value to a uint4 vector by assigning it to every component.</summary>
        
        public static implicit operator uint4(uint v) { return new uint4(v); }

        /// <summary>Explicitly converts a single bool value to a uint4 vector by converting it to uint and assigning it to every component.</summary>
        
        public static explicit operator uint4(bool v) { return new uint4(v); }

        /// <summary>Explicitly converts a bool4 vector to a uint4 vector by componentwise conversion.</summary>
        
        public static explicit operator uint4(bool4 v) { return new uint4(v); }

        /// <summary>Explicitly converts a single int value to a uint4 vector by converting it to uint and assigning it to every component.</summary>
        
        public static explicit operator uint4(int v) { return new uint4(v); }

        /// <summary>Explicitly converts a int4 vector to a uint4 vector by componentwise conversion.</summary>
        
        public static explicit operator uint4(int4 v) { return new uint4(v); }

        /// <summary>Explicitly converts a single float value to a uint4 vector by converting it to uint and assigning it to every component.</summary>
        
        public static explicit operator uint4(float v) { return new uint4(v); }

        /// <summary>Explicitly converts a float4 vector to a uint4 vector by componentwise conversion.</summary>
        
        public static explicit operator uint4(float4 v) { return new uint4(v); }

        /// <summary>Explicitly converts a single double value to a uint4 vector by converting it to uint and assigning it to every component.</summary>
        
        public static explicit operator uint4(double v) { return new uint4(v); }

        /// <summary>Explicitly converts a double4 vector to a uint4 vector by componentwise conversion.</summary>
        
        public static explicit operator uint4(double4 v) { return new uint4(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two uint4 vectors.</summary>
        
        public static uint4 operator * (uint4 lhs, uint4 rhs) { return new uint4 (lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w); }

        /// <summary>Returns the result of a componentwise multiplication operation on a uint4 vector and a uint value.</summary>
        
        public static uint4 operator * (uint4 lhs, uint rhs) { return new uint4 (lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a uint value and a uint4 vector.</summary>
        
        public static uint4 operator * (uint lhs, uint4 rhs) { return new uint4 (lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w); }


        /// <summary>Returns the result of a componentwise addition operation on two uint4 vectors.</summary>
        
        public static uint4 operator + (uint4 lhs, uint4 rhs) { return new uint4 (lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w); }

        /// <summary>Returns the result of a componentwise addition operation on a uint4 vector and a uint value.</summary>
        
        public static uint4 operator + (uint4 lhs, uint rhs) { return new uint4 (lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a uint value and a uint4 vector.</summary>
        
        public static uint4 operator + (uint lhs, uint4 rhs) { return new uint4 (lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w); }


        /// <summary>Returns the result of a componentwise subtraction operation on two uint4 vectors.</summary>
        
        public static uint4 operator - (uint4 lhs, uint4 rhs) { return new uint4 (lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w); }

        /// <summary>Returns the result of a componentwise subtraction operation on a uint4 vector and a uint value.</summary>
        
        public static uint4 operator - (uint4 lhs, uint rhs) { return new uint4 (lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a uint value and a uint4 vector.</summary>
        
        public static uint4 operator - (uint lhs, uint4 rhs) { return new uint4 (lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w); }


        /// <summary>Returns the result of a componentwise division operation on two uint4 vectors.</summary>
        
        public static uint4 operator / (uint4 lhs, uint4 rhs) { return new uint4 (lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w); }

        /// <summary>Returns the result of a componentwise division operation on a uint4 vector and a uint value.</summary>
        
        public static uint4 operator / (uint4 lhs, uint rhs) { return new uint4 (lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a uint value and a uint4 vector.</summary>
        
        public static uint4 operator / (uint lhs, uint4 rhs) { return new uint4 (lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w); }


        /// <summary>Returns the result of a componentwise modulus operation on two uint4 vectors.</summary>
        
        public static uint4 operator % (uint4 lhs, uint4 rhs) { return new uint4 (lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w); }

        /// <summary>Returns the result of a componentwise modulus operation on a uint4 vector and a uint value.</summary>
        
        public static uint4 operator % (uint4 lhs, uint rhs) { return new uint4 (lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a uint value and a uint4 vector.</summary>
        
        public static uint4 operator % (uint lhs, uint4 rhs) { return new uint4 (lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w); }


        /// <summary>Returns the result of a componentwise increment operation on a uint4 vector.</summary>
        
        public static uint4 operator ++ (uint4 val) { return new uint4 (++val.x, ++val.y, ++val.z, ++val.w); }


        /// <summary>Returns the result of a componentwise decrement operation on a uint4 vector.</summary>
        
        public static uint4 operator -- (uint4 val) { return new uint4 (--val.x, --val.y, --val.z, --val.w); }


        /// <summary>Returns the result of a componentwise less than operation on two uint4 vectors.</summary>
        
        public static bool4 operator < (uint4 lhs, uint4 rhs) { return new bool4 (lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w); }

        /// <summary>Returns the result of a componentwise less than operation on a uint4 vector and a uint value.</summary>
        
        public static bool4 operator < (uint4 lhs, uint rhs) { return new bool4 (lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a uint value and a uint4 vector.</summary>
        
        public static bool4 operator < (uint lhs, uint4 rhs) { return new bool4 (lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w); }


        /// <summary>Returns the result of a componentwise less or equal operation on two uint4 vectors.</summary>
        
        public static bool4 operator <= (uint4 lhs, uint4 rhs) { return new bool4 (lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w); }

        /// <summary>Returns the result of a componentwise less or equal operation on a uint4 vector and a uint value.</summary>
        
        public static bool4 operator <= (uint4 lhs, uint rhs) { return new bool4 (lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a uint value and a uint4 vector.</summary>
        
        public static bool4 operator <= (uint lhs, uint4 rhs) { return new bool4 (lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w); }


        /// <summary>Returns the result of a componentwise greater than operation on two uint4 vectors.</summary>
        
        public static bool4 operator > (uint4 lhs, uint4 rhs) { return new bool4 (lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w); }

        /// <summary>Returns the result of a componentwise greater than operation on a uint4 vector and a uint value.</summary>
        
        public static bool4 operator > (uint4 lhs, uint rhs) { return new bool4 (lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a uint value and a uint4 vector.</summary>
        
        public static bool4 operator > (uint lhs, uint4 rhs) { return new bool4 (lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two uint4 vectors.</summary>
        
        public static bool4 operator >= (uint4 lhs, uint4 rhs) { return new bool4 (lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a uint4 vector and a uint value.</summary>
        
        public static bool4 operator >= (uint4 lhs, uint rhs) { return new bool4 (lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a uint value and a uint4 vector.</summary>
        
        public static bool4 operator >= (uint lhs, uint4 rhs) { return new bool4 (lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w); }


        /// <summary>Returns the result of a componentwise unary minus operation on a uint4 vector.</summary>
        
        public static uint4 operator - (uint4 val) { return new uint4 ((uint)-val.x, (uint)-val.y, (uint)-val.z, (uint)-val.w); }


        /// <summary>Returns the result of a componentwise unary plus operation on a uint4 vector.</summary>
        
        public static uint4 operator + (uint4 val) { return new uint4 (+val.x, +val.y, +val.z, +val.w); }


        /// <summary>Returns the result of a componentwise left shift operation on a uint4 vector by a number of bits specified by a single int.</summary>
        
        public static uint4 operator << (uint4 x, int n) { return new uint4 (x.x << n, x.y << n, x.z << n, x.w << n); }

        /// <summary>Returns the result of a componentwise right shift operation on a uint4 vector by a number of bits specified by a single int.</summary>
        
        public static uint4 operator >> (uint4 x, int n) { return new uint4 (x.x >> n, x.y >> n, x.z >> n, x.w >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two uint4 vectors.</summary>
        
        public static bool4 operator == (uint4 lhs, uint4 rhs) { return new bool4 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w); }

        /// <summary>Returns the result of a componentwise equality operation on a uint4 vector and a uint value.</summary>
        
        public static bool4 operator == (uint4 lhs, uint rhs) { return new bool4 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a uint value and a uint4 vector.</summary>
        
        public static bool4 operator == (uint lhs, uint4 rhs) { return new bool4 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w); }


        /// <summary>Returns the result of a componentwise not equal operation on two uint4 vectors.</summary>
        
        public static bool4 operator != (uint4 lhs, uint4 rhs) { return new bool4 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w); }

        /// <summary>Returns the result of a componentwise not equal operation on a uint4 vector and a uint value.</summary>
        
        public static bool4 operator != (uint4 lhs, uint rhs) { return new bool4 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a uint value and a uint4 vector.</summary>
        
        public static bool4 operator != (uint lhs, uint4 rhs) { return new bool4 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w); }


        /// <summary>Returns the result of a componentwise bitwise not operation on a uint4 vector.</summary>
        
        public static uint4 operator ~ (uint4 val) { return new uint4 (~val.x, ~val.y, ~val.z, ~val.w); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two uint4 vectors.</summary>
        
        public static uint4 operator & (uint4 lhs, uint4 rhs) { return new uint4 (lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z, lhs.w & rhs.w); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a uint4 vector and a uint value.</summary>
        
        public static uint4 operator & (uint4 lhs, uint rhs) { return new uint4 (lhs.x & rhs, lhs.y & rhs, lhs.z & rhs, lhs.w & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a uint value and a uint4 vector.</summary>
        
        public static uint4 operator & (uint lhs, uint4 rhs) { return new uint4 (lhs & rhs.x, lhs & rhs.y, lhs & rhs.z, lhs & rhs.w); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two uint4 vectors.</summary>
        
        public static uint4 operator | (uint4 lhs, uint4 rhs) { return new uint4 (lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z, lhs.w | rhs.w); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint4 vector and a uint value.</summary>
        
        public static uint4 operator | (uint4 lhs, uint rhs) { return new uint4 (lhs.x | rhs, lhs.y | rhs, lhs.z | rhs, lhs.w | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint value and a uint4 vector.</summary>
        
        public static uint4 operator | (uint lhs, uint4 rhs) { return new uint4 (lhs | rhs.x, lhs | rhs.y, lhs | rhs.z, lhs | rhs.w); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two uint4 vectors.</summary>
        
        public static uint4 operator ^ (uint4 lhs, uint4 rhs) { return new uint4 (lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z, lhs.w ^ rhs.w); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a uint4 vector and a uint value.</summary>
        
        public static uint4 operator ^ (uint4 lhs, uint rhs) { return new uint4 (lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs, lhs.w ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a uint value and a uint4 vector.</summary>
        
        public static uint4 operator ^ (uint lhs, uint4 rhs) { return new uint4 (lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z, lhs ^ rhs.w); }




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
        public uint4 xxxw
        {
            
            get { return new uint4(x, x, x, w); }
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
        public uint4 xxyw
        {
            
            get { return new uint4(x, x, y, w); }
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
        public uint4 xxzw
        {
            
            get { return new uint4(x, x, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxwx
        {
            
            get { return new uint4(x, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxwy
        {
            
            get { return new uint4(x, x, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxwz
        {
            
            get { return new uint4(x, x, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxww
        {
            
            get { return new uint4(x, x, w, w); }
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
        public uint4 xyxw
        {
            
            get { return new uint4(x, y, x, w); }
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
        public uint4 xyyw
        {
            
            get { return new uint4(x, y, y, w); }
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
        public uint4 xyzw
        {
            
            get { return new uint4(x, y, z, w); }
            
            set { x = value.x; y = value.y; z = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xywx
        {
            
            get { return new uint4(x, y, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xywy
        {
            
            get { return new uint4(x, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xywz
        {
            
            get { return new uint4(x, y, w, z); }
            
            set { x = value.x; y = value.y; w = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyww
        {
            
            get { return new uint4(x, y, w, w); }
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
        public uint4 xzxw
        {
            
            get { return new uint4(x, z, x, w); }
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
        public uint4 xzyw
        {
            
            get { return new uint4(x, z, y, w); }
            
            set { x = value.x; z = value.y; y = value.z; w = value.w; }
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
        public uint4 xzzw
        {
            
            get { return new uint4(x, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xzwx
        {
            
            get { return new uint4(x, z, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xzwy
        {
            
            get { return new uint4(x, z, w, y); }
            
            set { x = value.x; z = value.y; w = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xzwz
        {
            
            get { return new uint4(x, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xzww
        {
            
            get { return new uint4(x, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xwxx
        {
            
            get { return new uint4(x, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xwxy
        {
            
            get { return new uint4(x, w, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xwxz
        {
            
            get { return new uint4(x, w, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xwxw
        {
            
            get { return new uint4(x, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xwyx
        {
            
            get { return new uint4(x, w, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xwyy
        {
            
            get { return new uint4(x, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xwyz
        {
            
            get { return new uint4(x, w, y, z); }
            
            set { x = value.x; w = value.y; y = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xwyw
        {
            
            get { return new uint4(x, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xwzx
        {
            
            get { return new uint4(x, w, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xwzy
        {
            
            get { return new uint4(x, w, z, y); }
            
            set { x = value.x; w = value.y; z = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xwzz
        {
            
            get { return new uint4(x, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xwzw
        {
            
            get { return new uint4(x, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xwwx
        {
            
            get { return new uint4(x, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xwwy
        {
            
            get { return new uint4(x, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xwwz
        {
            
            get { return new uint4(x, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xwww
        {
            
            get { return new uint4(x, w, w, w); }
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
        public uint4 yxxw
        {
            
            get { return new uint4(y, x, x, w); }
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
        public uint4 yxyw
        {
            
            get { return new uint4(y, x, y, w); }
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
        public uint4 yxzw
        {
            
            get { return new uint4(y, x, z, w); }
            
            set { y = value.x; x = value.y; z = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxwx
        {
            
            get { return new uint4(y, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxwy
        {
            
            get { return new uint4(y, x, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxwz
        {
            
            get { return new uint4(y, x, w, z); }
            
            set { y = value.x; x = value.y; w = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxww
        {
            
            get { return new uint4(y, x, w, w); }
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
        public uint4 yyxw
        {
            
            get { return new uint4(y, y, x, w); }
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
        public uint4 yyyw
        {
            
            get { return new uint4(y, y, y, w); }
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
        public uint4 yyzw
        {
            
            get { return new uint4(y, y, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yywx
        {
            
            get { return new uint4(y, y, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yywy
        {
            
            get { return new uint4(y, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yywz
        {
            
            get { return new uint4(y, y, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyww
        {
            
            get { return new uint4(y, y, w, w); }
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
        public uint4 yzxw
        {
            
            get { return new uint4(y, z, x, w); }
            
            set { y = value.x; z = value.y; x = value.z; w = value.w; }
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
        public uint4 yzyw
        {
            
            get { return new uint4(y, z, y, w); }
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
        public uint4 yzzw
        {
            
            get { return new uint4(y, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yzwx
        {
            
            get { return new uint4(y, z, w, x); }
            
            set { y = value.x; z = value.y; w = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yzwy
        {
            
            get { return new uint4(y, z, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yzwz
        {
            
            get { return new uint4(y, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yzww
        {
            
            get { return new uint4(y, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 ywxx
        {
            
            get { return new uint4(y, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 ywxy
        {
            
            get { return new uint4(y, w, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 ywxz
        {
            
            get { return new uint4(y, w, x, z); }
            
            set { y = value.x; w = value.y; x = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 ywxw
        {
            
            get { return new uint4(y, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 ywyx
        {
            
            get { return new uint4(y, w, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 ywyy
        {
            
            get { return new uint4(y, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 ywyz
        {
            
            get { return new uint4(y, w, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 ywyw
        {
            
            get { return new uint4(y, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 ywzx
        {
            
            get { return new uint4(y, w, z, x); }
            
            set { y = value.x; w = value.y; z = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 ywzy
        {
            
            get { return new uint4(y, w, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 ywzz
        {
            
            get { return new uint4(y, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 ywzw
        {
            
            get { return new uint4(y, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 ywwx
        {
            
            get { return new uint4(y, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 ywwy
        {
            
            get { return new uint4(y, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 ywwz
        {
            
            get { return new uint4(y, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 ywww
        {
            
            get { return new uint4(y, w, w, w); }
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
        public uint4 zxxw
        {
            
            get { return new uint4(z, x, x, w); }
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
        public uint4 zxyw
        {
            
            get { return new uint4(z, x, y, w); }
            
            set { z = value.x; x = value.y; y = value.z; w = value.w; }
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
        public uint4 zxzw
        {
            
            get { return new uint4(z, x, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zxwx
        {
            
            get { return new uint4(z, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zxwy
        {
            
            get { return new uint4(z, x, w, y); }
            
            set { z = value.x; x = value.y; w = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zxwz
        {
            
            get { return new uint4(z, x, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zxww
        {
            
            get { return new uint4(z, x, w, w); }
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
        public uint4 zyxw
        {
            
            get { return new uint4(z, y, x, w); }
            
            set { z = value.x; y = value.y; x = value.z; w = value.w; }
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
        public uint4 zyyw
        {
            
            get { return new uint4(z, y, y, w); }
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
        public uint4 zyzw
        {
            
            get { return new uint4(z, y, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zywx
        {
            
            get { return new uint4(z, y, w, x); }
            
            set { z = value.x; y = value.y; w = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zywy
        {
            
            get { return new uint4(z, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zywz
        {
            
            get { return new uint4(z, y, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zyww
        {
            
            get { return new uint4(z, y, w, w); }
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
        public uint4 zzxw
        {
            
            get { return new uint4(z, z, x, w); }
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
        public uint4 zzyw
        {
            
            get { return new uint4(z, z, y, w); }
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
        public uint4 zzzw
        {
            
            get { return new uint4(z, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zzwx
        {
            
            get { return new uint4(z, z, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zzwy
        {
            
            get { return new uint4(z, z, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zzwz
        {
            
            get { return new uint4(z, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zzww
        {
            
            get { return new uint4(z, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zwxx
        {
            
            get { return new uint4(z, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zwxy
        {
            
            get { return new uint4(z, w, x, y); }
            
            set { z = value.x; w = value.y; x = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zwxz
        {
            
            get { return new uint4(z, w, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zwxw
        {
            
            get { return new uint4(z, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zwyx
        {
            
            get { return new uint4(z, w, y, x); }
            
            set { z = value.x; w = value.y; y = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zwyy
        {
            
            get { return new uint4(z, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zwyz
        {
            
            get { return new uint4(z, w, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zwyw
        {
            
            get { return new uint4(z, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zwzx
        {
            
            get { return new uint4(z, w, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zwzy
        {
            
            get { return new uint4(z, w, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zwzz
        {
            
            get { return new uint4(z, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zwzw
        {
            
            get { return new uint4(z, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zwwx
        {
            
            get { return new uint4(z, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zwwy
        {
            
            get { return new uint4(z, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zwwz
        {
            
            get { return new uint4(z, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 zwww
        {
            
            get { return new uint4(z, w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wxxx
        {
            
            get { return new uint4(w, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wxxy
        {
            
            get { return new uint4(w, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wxxz
        {
            
            get { return new uint4(w, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wxxw
        {
            
            get { return new uint4(w, x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wxyx
        {
            
            get { return new uint4(w, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wxyy
        {
            
            get { return new uint4(w, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wxyz
        {
            
            get { return new uint4(w, x, y, z); }
            
            set { w = value.x; x = value.y; y = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wxyw
        {
            
            get { return new uint4(w, x, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wxzx
        {
            
            get { return new uint4(w, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wxzy
        {
            
            get { return new uint4(w, x, z, y); }
            
            set { w = value.x; x = value.y; z = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wxzz
        {
            
            get { return new uint4(w, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wxzw
        {
            
            get { return new uint4(w, x, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wxwx
        {
            
            get { return new uint4(w, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wxwy
        {
            
            get { return new uint4(w, x, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wxwz
        {
            
            get { return new uint4(w, x, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wxww
        {
            
            get { return new uint4(w, x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wyxx
        {
            
            get { return new uint4(w, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wyxy
        {
            
            get { return new uint4(w, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wyxz
        {
            
            get { return new uint4(w, y, x, z); }
            
            set { w = value.x; y = value.y; x = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wyxw
        {
            
            get { return new uint4(w, y, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wyyx
        {
            
            get { return new uint4(w, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wyyy
        {
            
            get { return new uint4(w, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wyyz
        {
            
            get { return new uint4(w, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wyyw
        {
            
            get { return new uint4(w, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wyzx
        {
            
            get { return new uint4(w, y, z, x); }
            
            set { w = value.x; y = value.y; z = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wyzy
        {
            
            get { return new uint4(w, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wyzz
        {
            
            get { return new uint4(w, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wyzw
        {
            
            get { return new uint4(w, y, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wywx
        {
            
            get { return new uint4(w, y, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wywy
        {
            
            get { return new uint4(w, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wywz
        {
            
            get { return new uint4(w, y, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wyww
        {
            
            get { return new uint4(w, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wzxx
        {
            
            get { return new uint4(w, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wzxy
        {
            
            get { return new uint4(w, z, x, y); }
            
            set { w = value.x; z = value.y; x = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wzxz
        {
            
            get { return new uint4(w, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wzxw
        {
            
            get { return new uint4(w, z, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wzyx
        {
            
            get { return new uint4(w, z, y, x); }
            
            set { w = value.x; z = value.y; y = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wzyy
        {
            
            get { return new uint4(w, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wzyz
        {
            
            get { return new uint4(w, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wzyw
        {
            
            get { return new uint4(w, z, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wzzx
        {
            
            get { return new uint4(w, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wzzy
        {
            
            get { return new uint4(w, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wzzz
        {
            
            get { return new uint4(w, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wzzw
        {
            
            get { return new uint4(w, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wzwx
        {
            
            get { return new uint4(w, z, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wzwy
        {
            
            get { return new uint4(w, z, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wzwz
        {
            
            get { return new uint4(w, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wzww
        {
            
            get { return new uint4(w, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wwxx
        {
            
            get { return new uint4(w, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wwxy
        {
            
            get { return new uint4(w, w, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wwxz
        {
            
            get { return new uint4(w, w, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wwxw
        {
            
            get { return new uint4(w, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wwyx
        {
            
            get { return new uint4(w, w, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wwyy
        {
            
            get { return new uint4(w, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wwyz
        {
            
            get { return new uint4(w, w, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wwyw
        {
            
            get { return new uint4(w, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wwzx
        {
            
            get { return new uint4(w, w, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wwzy
        {
            
            get { return new uint4(w, w, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wwzz
        {
            
            get { return new uint4(w, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wwzw
        {
            
            get { return new uint4(w, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wwwx
        {
            
            get { return new uint4(w, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wwwy
        {
            
            get { return new uint4(w, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wwwz
        {
            
            get { return new uint4(w, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 wwww
        {
            
            get { return new uint4(w, w, w, w); }
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
        public uint3 xxw
        {
            
            get { return new uint3(x, x, w); }
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
        public uint3 xyw
        {
            
            get { return new uint3(x, y, w); }
            
            set { x = value.x; y = value.y; w = value.z; }
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
        public uint3 xzw
        {
            
            get { return new uint3(x, z, w); }
            
            set { x = value.x; z = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xwx
        {
            
            get { return new uint3(x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xwy
        {
            
            get { return new uint3(x, w, y); }
            
            set { x = value.x; w = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xwz
        {
            
            get { return new uint3(x, w, z); }
            
            set { x = value.x; w = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xww
        {
            
            get { return new uint3(x, w, w); }
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
        public uint3 yxw
        {
            
            get { return new uint3(y, x, w); }
            
            set { y = value.x; x = value.y; w = value.z; }
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
        public uint3 yyw
        {
            
            get { return new uint3(y, y, w); }
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
        public uint3 yzw
        {
            
            get { return new uint3(y, z, w); }
            
            set { y = value.x; z = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 ywx
        {
            
            get { return new uint3(y, w, x); }
            
            set { y = value.x; w = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 ywy
        {
            
            get { return new uint3(y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 ywz
        {
            
            get { return new uint3(y, w, z); }
            
            set { y = value.x; w = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yww
        {
            
            get { return new uint3(y, w, w); }
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
        public uint3 zxw
        {
            
            get { return new uint3(z, x, w); }
            
            set { z = value.x; x = value.y; w = value.z; }
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
        public uint3 zyw
        {
            
            get { return new uint3(z, y, w); }
            
            set { z = value.x; y = value.y; w = value.z; }
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
        public uint3 zzw
        {
            
            get { return new uint3(z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 zwx
        {
            
            get { return new uint3(z, w, x); }
            
            set { z = value.x; w = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 zwy
        {
            
            get { return new uint3(z, w, y); }
            
            set { z = value.x; w = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 zwz
        {
            
            get { return new uint3(z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 zww
        {
            
            get { return new uint3(z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 wxx
        {
            
            get { return new uint3(w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 wxy
        {
            
            get { return new uint3(w, x, y); }
            
            set { w = value.x; x = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 wxz
        {
            
            get { return new uint3(w, x, z); }
            
            set { w = value.x; x = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 wxw
        {
            
            get { return new uint3(w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 wyx
        {
            
            get { return new uint3(w, y, x); }
            
            set { w = value.x; y = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 wyy
        {
            
            get { return new uint3(w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 wyz
        {
            
            get { return new uint3(w, y, z); }
            
            set { w = value.x; y = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 wyw
        {
            
            get { return new uint3(w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 wzx
        {
            
            get { return new uint3(w, z, x); }
            
            set { w = value.x; z = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 wzy
        {
            
            get { return new uint3(w, z, y); }
            
            set { w = value.x; z = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 wzz
        {
            
            get { return new uint3(w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 wzw
        {
            
            get { return new uint3(w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 wwx
        {
            
            get { return new uint3(w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 wwy
        {
            
            get { return new uint3(w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 wwz
        {
            
            get { return new uint3(w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 www
        {
            
            get { return new uint3(w, w, w); }
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
        public uint2 xw
        {
            
            get { return new uint2(x, w); }
            
            set { x = value.x; w = value.y; }
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
        public uint2 yw
        {
            
            get { return new uint2(y, w); }
            
            set { y = value.x; w = value.y; }
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


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 zw
        {
            
            get { return new uint2(z, w); }
            
            set { z = value.x; w = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 wx
        {
            
            get { return new uint2(w, x); }
            
            set { w = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 wy
        {
            
            get { return new uint2(w, y); }
            
            set { w = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 wz
        {
            
            get { return new uint2(w, z); }
            
            set { w = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 ww
        {
            
            get { return new uint2(w, w); }
        }



        /// <summary>Returns the uint element at a specified index.</summary>
        unsafe public uint this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (uint4* array = &this) { return ((uint*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (uint* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the uint4 is equal to a given uint4, false otherwise.</summary>
        
        public bool Equals(uint4 rhs) { return x == rhs.x && y == rhs.y && z == rhs.z && w == rhs.w; }

        /// <summary>Returns true if the uint4 is equal to a given uint4, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((uint4)o); }


        /// <summary>Returns a hash code for the uint4.</summary>
        
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the uint4.</summary>
        
        public override string ToString()
        {
            return string.Format("uint4({0}, {1}, {2}, {3})", x, y, z, w);
        }

        /// <summary>Returns a string representation of the uint4 using a specified format and culture-specific format information.</summary>
        
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("uint4({0}, {1}, {2}, {3})", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider), w.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public uint x;
            public uint y;
            public uint z;
            public uint w;
            public DebuggerProxy(uint4 v)
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
        /// <summary>Returns a uint4 vector constructed from four uint values.</summary>
        
        public static uint4 uint4(uint x, uint y, uint z, uint w) { return new uint4(x, y, z, w); }

        /// <summary>Returns a uint4 vector constructed from two uint values and a uint2 vector.</summary>
        
        public static uint4 uint4(uint x, uint y, uint2 zw) { return new uint4(x, y, zw); }

        /// <summary>Returns a uint4 vector constructed from a uint value, a uint2 vector and a uint value.</summary>
        
        public static uint4 uint4(uint x, uint2 yz, uint w) { return new uint4(x, yz, w); }

        /// <summary>Returns a uint4 vector constructed from a uint value and a uint3 vector.</summary>
        
        public static uint4 uint4(uint x, uint3 yzw) { return new uint4(x, yzw); }

        /// <summary>Returns a uint4 vector constructed from a uint2 vector and two uint values.</summary>
        
        public static uint4 uint4(uint2 xy, uint z, uint w) { return new uint4(xy, z, w); }

        /// <summary>Returns a uint4 vector constructed from two uint2 vectors.</summary>
        
        public static uint4 uint4(uint2 xy, uint2 zw) { return new uint4(xy, zw); }

        /// <summary>Returns a uint4 vector constructed from a uint3 vector and a uint value.</summary>
        
        public static uint4 uint4(uint3 xyz, uint w) { return new uint4(xyz, w); }

        /// <summary>Returns a uint4 vector constructed from a uint4 vector.</summary>
        
        public static uint4 uint4(uint4 xyzw) { return new uint4(xyzw); }

        /// <summary>Returns a uint4 vector constructed from a single uint value by assigning it to every component.</summary>
        
        public static uint4 uint4(uint v) { return new uint4(v); }

        /// <summary>Returns a uint4 vector constructed from a single bool value by converting it to uint and assigning it to every component.</summary>
        
        public static uint4 uint4(bool v) { return new uint4(v); }

        /// <summary>Return a uint4 vector constructed from a bool4 vector by componentwise conversion.</summary>
        
        public static uint4 uint4(bool4 v) { return new uint4(v); }

        /// <summary>Returns a uint4 vector constructed from a single int value by converting it to uint and assigning it to every component.</summary>
        
        public static uint4 uint4(int v) { return new uint4(v); }

        /// <summary>Return a uint4 vector constructed from a int4 vector by componentwise conversion.</summary>
        
        public static uint4 uint4(int4 v) { return new uint4(v); }

        /// <summary>Returns a uint4 vector constructed from a single float value by converting it to uint and assigning it to every component.</summary>
        
        public static uint4 uint4(float v) { return new uint4(v); }

        /// <summary>Return a uint4 vector constructed from a float4 vector by componentwise conversion.</summary>
        
        public static uint4 uint4(float4 v) { return new uint4(v); }

        /// <summary>Returns a uint4 vector constructed from a single double value by converting it to uint and assigning it to every component.</summary>
        
        public static uint4 uint4(double v) { return new uint4(v); }

        /// <summary>Return a uint4 vector constructed from a double4 vector by componentwise conversion.</summary>
        
        public static uint4 uint4(double4 v) { return new uint4(v); }

        /// <summary>Returns a uint hash code of a uint4 vector.</summary>
        
        public static uint hash(uint4 v)
        {
            return csum(v * uint4(0xB492BF15u, 0xD37220E3u, 0x7AA2C2BDu, 0xE16BC89Du)) + 0x7AA07CD3u;
        }

        /// <summary>
        /// Returns a uint4 vector hash code of a uint4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        
        public static uint4 hashwide(uint4 v)
        {
            return (v * uint4(0xAF642BA9u, 0xA8F2213Bu, 0x9F3FDC37u, 0xAC60D0C3u)) + 0x9263662Fu;
        }

        /// <summary>Returns the result of specified shuffling of the components from two uint4 vectors into a uint value.</summary>
        
        public static uint shuffle(uint4 a, uint4 b, ShuffleComponent x)
        {
            return select_shuffle_component(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two uint4 vectors into a uint2 vector.</summary>
        
        public static uint2 shuffle(uint4 a, uint4 b, ShuffleComponent x, ShuffleComponent y)
        {
            return uint2(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two uint4 vectors into a uint3 vector.</summary>
        
        public static uint3 shuffle(uint4 a, uint4 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return uint3(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two uint4 vectors into a uint4 vector.</summary>
        
        public static uint4 shuffle(uint4 a, uint4 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return uint4(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z),
                select_shuffle_component(a, b, w));
        }

        
        internal static uint select_shuffle_component(uint4 a, uint4 b, ShuffleComponent component)
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

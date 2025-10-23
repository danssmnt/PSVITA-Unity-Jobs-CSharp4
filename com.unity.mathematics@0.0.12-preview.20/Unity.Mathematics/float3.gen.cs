// GENERATED CODE
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(float3.DebuggerProxy))]
    [System.Serializable]
    public partial struct float3 : System.IEquatable<float3>, IFormattable
    {
        public float x;
        public float y;
        public float z;

        /// <summary>float3 zero value.</summary>
        public static readonly float3 zero;

        /// <summary>Constructs a float3 vector from three float values.</summary>
        
        public float3(float x, float y, float z)
        { 
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>Constructs a float3 vector from a float value and a float2 vector.</summary>
        
        public float3(float x, float2 yz)
        { 
            this.x = x;
            this.y = yz.x;
            this.z = yz.y;
        }

        /// <summary>Constructs a float3 vector from a float2 vector and a float value.</summary>
        
        public float3(float2 xy, float z)
        { 
            this.x = xy.x;
            this.y = xy.y;
            this.z = z;
        }

        /// <summary>Constructs a float3 vector from a float3 vector.</summary>
        
        public float3(float3 xyz)
        { 
            this.x = xyz.x;
            this.y = xyz.y;
            this.z = xyz.z;
        }

        /// <summary>Constructs a float3 vector from a single float value by assigning it to every component.</summary>
        
        public float3(float v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }

        /// <summary>Constructs a float3 vector from a single bool value by converting it to float and assigning it to every component.</summary>
        
        public float3(bool v)
        {
            this.x = v ? 1.0f : 0.0f;
            this.y = v ? 1.0f : 0.0f;
            this.z = v ? 1.0f : 0.0f;
        }

        /// <summary>Constructs a float3 vector from a bool3 vector by componentwise conversion.</summary>
        
        public float3(bool3 v)
        {
            this.x = v.x ? 1.0f : 0.0f;
            this.y = v.y ? 1.0f : 0.0f;
            this.z = v.z ? 1.0f : 0.0f;
        }

        /// <summary>Constructs a float3 vector from a single int value by converting it to float and assigning it to every component.</summary>
        
        public float3(int v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }

        /// <summary>Constructs a float3 vector from a int3 vector by componentwise conversion.</summary>
        
        public float3(int3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }

        /// <summary>Constructs a float3 vector from a single uint value by converting it to float and assigning it to every component.</summary>
        
        public float3(uint v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }

        /// <summary>Constructs a float3 vector from a uint3 vector by componentwise conversion.</summary>
        
        public float3(uint3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }

        /// <summary>Constructs a float3 vector from a single half value by converting it to float and assigning it to every component.</summary>
        
        public float3(half v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }

        /// <summary>Constructs a float3 vector from a half3 vector by componentwise conversion.</summary>
        
        public float3(half3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }

        /// <summary>Constructs a float3 vector from a single double value by converting it to float and assigning it to every component.</summary>
        
        public float3(double v)
        {
            this.x = (float)v;
            this.y = (float)v;
            this.z = (float)v;
        }

        /// <summary>Constructs a float3 vector from a double3 vector by componentwise conversion.</summary>
        
        public float3(double3 v)
        {
            this.x = (float)v.x;
            this.y = (float)v.y;
            this.z = (float)v.z;
        }


        /// <summary>Implicitly converts a single float value to a float3 vector by assigning it to every component.</summary>
        
        public static implicit operator float3(float v) { return new float3(v); }

        /// <summary>Explicitly converts a single bool value to a float3 vector by converting it to float and assigning it to every component.</summary>
        
        public static explicit operator float3(bool v) { return new float3(v); }

        /// <summary>Explicitly converts a bool3 vector to a float3 vector by componentwise conversion.</summary>
        
        public static explicit operator float3(bool3 v) { return new float3(v); }

        /// <summary>Implicitly converts a single int value to a float3 vector by converting it to float and assigning it to every component.</summary>
        
        public static implicit operator float3(int v) { return new float3(v); }

        /// <summary>Implicitly converts a int3 vector to a float3 vector by componentwise conversion.</summary>
        
        public static implicit operator float3(int3 v) { return new float3(v); }

        /// <summary>Implicitly converts a single uint value to a float3 vector by converting it to float and assigning it to every component.</summary>
        
        public static implicit operator float3(uint v) { return new float3(v); }

        /// <summary>Implicitly converts a uint3 vector to a float3 vector by componentwise conversion.</summary>
        
        public static implicit operator float3(uint3 v) { return new float3(v); }

        /// <summary>Implicitly converts a single half value to a float3 vector by converting it to float and assigning it to every component.</summary>
        
        public static implicit operator float3(half v) { return new float3(v); }

        /// <summary>Implicitly converts a half3 vector to a float3 vector by componentwise conversion.</summary>
        
        public static implicit operator float3(half3 v) { return new float3(v); }

        /// <summary>Explicitly converts a single double value to a float3 vector by converting it to float and assigning it to every component.</summary>
        
        public static explicit operator float3(double v) { return new float3(v); }

        /// <summary>Explicitly converts a double3 vector to a float3 vector by componentwise conversion.</summary>
        
        public static explicit operator float3(double3 v) { return new float3(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two float3 vectors.</summary>
        
        public static float3 operator * (float3 lhs, float3 rhs) { return new float3 (lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z); }

        /// <summary>Returns the result of a componentwise multiplication operation on a float3 vector and a float value.</summary>
        
        public static float3 operator * (float3 lhs, float rhs) { return new float3 (lhs.x * rhs, lhs.y * rhs, lhs.z * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a float value and a float3 vector.</summary>
        
        public static float3 operator * (float lhs, float3 rhs) { return new float3 (lhs * rhs.x, lhs * rhs.y, lhs * rhs.z); }


        /// <summary>Returns the result of a componentwise addition operation on two float3 vectors.</summary>
        
        public static float3 operator + (float3 lhs, float3 rhs) { return new float3 (lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z); }

        /// <summary>Returns the result of a componentwise addition operation on a float3 vector and a float value.</summary>
        
        public static float3 operator + (float3 lhs, float rhs) { return new float3 (lhs.x + rhs, lhs.y + rhs, lhs.z + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a float value and a float3 vector.</summary>
        
        public static float3 operator + (float lhs, float3 rhs) { return new float3 (lhs + rhs.x, lhs + rhs.y, lhs + rhs.z); }


        /// <summary>Returns the result of a componentwise subtraction operation on two float3 vectors.</summary>
        
        public static float3 operator - (float3 lhs, float3 rhs) { return new float3 (lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z); }

        /// <summary>Returns the result of a componentwise subtraction operation on a float3 vector and a float value.</summary>
        
        public static float3 operator - (float3 lhs, float rhs) { return new float3 (lhs.x - rhs, lhs.y - rhs, lhs.z - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a float value and a float3 vector.</summary>
        
        public static float3 operator - (float lhs, float3 rhs) { return new float3 (lhs - rhs.x, lhs - rhs.y, lhs - rhs.z); }


        /// <summary>Returns the result of a componentwise division operation on two float3 vectors.</summary>
        
        public static float3 operator / (float3 lhs, float3 rhs) { return new float3 (lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z); }

        /// <summary>Returns the result of a componentwise division operation on a float3 vector and a float value.</summary>
        
        public static float3 operator / (float3 lhs, float rhs) { return new float3 (lhs.x / rhs, lhs.y / rhs, lhs.z / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a float value and a float3 vector.</summary>
        
        public static float3 operator / (float lhs, float3 rhs) { return new float3 (lhs / rhs.x, lhs / rhs.y, lhs / rhs.z); }


        /// <summary>Returns the result of a componentwise modulus operation on two float3 vectors.</summary>
        
        public static float3 operator % (float3 lhs, float3 rhs) { return new float3 (lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z); }

        /// <summary>Returns the result of a componentwise modulus operation on a float3 vector and a float value.</summary>
        
        public static float3 operator % (float3 lhs, float rhs) { return new float3 (lhs.x % rhs, lhs.y % rhs, lhs.z % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a float value and a float3 vector.</summary>
        
        public static float3 operator % (float lhs, float3 rhs) { return new float3 (lhs % rhs.x, lhs % rhs.y, lhs % rhs.z); }


        /// <summary>Returns the result of a componentwise increment operation on a float3 vector.</summary>
        
        public static float3 operator ++ (float3 val) { return new float3 (++val.x, ++val.y, ++val.z); }


        /// <summary>Returns the result of a componentwise decrement operation on a float3 vector.</summary>
        
        public static float3 operator -- (float3 val) { return new float3 (--val.x, --val.y, --val.z); }


        /// <summary>Returns the result of a componentwise less than operation on two float3 vectors.</summary>
        
        public static bool3 operator < (float3 lhs, float3 rhs) { return new bool3 (lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z); }

        /// <summary>Returns the result of a componentwise less than operation on a float3 vector and a float value.</summary>
        
        public static bool3 operator < (float3 lhs, float rhs) { return new bool3 (lhs.x < rhs, lhs.y < rhs, lhs.z < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a float value and a float3 vector.</summary>
        
        public static bool3 operator < (float lhs, float3 rhs) { return new bool3 (lhs < rhs.x, lhs < rhs.y, lhs < rhs.z); }


        /// <summary>Returns the result of a componentwise less or equal operation on two float3 vectors.</summary>
        
        public static bool3 operator <= (float3 lhs, float3 rhs) { return new bool3 (lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z); }

        /// <summary>Returns the result of a componentwise less or equal operation on a float3 vector and a float value.</summary>
        
        public static bool3 operator <= (float3 lhs, float rhs) { return new bool3 (lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a float value and a float3 vector.</summary>
        
        public static bool3 operator <= (float lhs, float3 rhs) { return new bool3 (lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z); }


        /// <summary>Returns the result of a componentwise greater than operation on two float3 vectors.</summary>
        
        public static bool3 operator > (float3 lhs, float3 rhs) { return new bool3 (lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z); }

        /// <summary>Returns the result of a componentwise greater than operation on a float3 vector and a float value.</summary>
        
        public static bool3 operator > (float3 lhs, float rhs) { return new bool3 (lhs.x > rhs, lhs.y > rhs, lhs.z > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a float value and a float3 vector.</summary>
        
        public static bool3 operator > (float lhs, float3 rhs) { return new bool3 (lhs > rhs.x, lhs > rhs.y, lhs > rhs.z); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two float3 vectors.</summary>
        
        public static bool3 operator >= (float3 lhs, float3 rhs) { return new bool3 (lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float3 vector and a float value.</summary>
        
        public static bool3 operator >= (float3 lhs, float rhs) { return new bool3 (lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float value and a float3 vector.</summary>
        
        public static bool3 operator >= (float lhs, float3 rhs) { return new bool3 (lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z); }


        /// <summary>Returns the result of a componentwise unary minus operation on a float3 vector.</summary>
        
        public static float3 operator - (float3 val) { return new float3 (-val.x, -val.y, -val.z); }


        /// <summary>Returns the result of a componentwise unary plus operation on a float3 vector.</summary>
        
        public static float3 operator + (float3 val) { return new float3 (+val.x, +val.y, +val.z); }


        /// <summary>Returns the result of a componentwise equality operation on two float3 vectors.</summary>
        
        public static bool3 operator == (float3 lhs, float3 rhs) { return new bool3 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z); }

        /// <summary>Returns the result of a componentwise equality operation on a float3 vector and a float value.</summary>
        
        public static bool3 operator == (float3 lhs, float rhs) { return new bool3 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a float value and a float3 vector.</summary>
        
        public static bool3 operator == (float lhs, float3 rhs) { return new bool3 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z); }


        /// <summary>Returns the result of a componentwise not equal operation on two float3 vectors.</summary>
        
        public static bool3 operator != (float3 lhs, float3 rhs) { return new bool3 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z); }

        /// <summary>Returns the result of a componentwise not equal operation on a float3 vector and a float value.</summary>
        
        public static bool3 operator != (float3 lhs, float rhs) { return new bool3 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a float value and a float3 vector.</summary>
        
        public static bool3 operator != (float lhs, float3 rhs) { return new bool3 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z); }




        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxxx
        {
            
            get { return new float4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxxy
        {
            
            get { return new float4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxxz
        {
            
            get { return new float4(x, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxyx
        {
            
            get { return new float4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxyy
        {
            
            get { return new float4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxyz
        {
            
            get { return new float4(x, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxzx
        {
            
            get { return new float4(x, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxzy
        {
            
            get { return new float4(x, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxzz
        {
            
            get { return new float4(x, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyxx
        {
            
            get { return new float4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyxy
        {
            
            get { return new float4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyxz
        {
            
            get { return new float4(x, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyyx
        {
            
            get { return new float4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyyy
        {
            
            get { return new float4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyyz
        {
            
            get { return new float4(x, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyzx
        {
            
            get { return new float4(x, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyzy
        {
            
            get { return new float4(x, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyzz
        {
            
            get { return new float4(x, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xzxx
        {
            
            get { return new float4(x, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xzxy
        {
            
            get { return new float4(x, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xzxz
        {
            
            get { return new float4(x, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xzyx
        {
            
            get { return new float4(x, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xzyy
        {
            
            get { return new float4(x, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xzyz
        {
            
            get { return new float4(x, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xzzx
        {
            
            get { return new float4(x, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xzzy
        {
            
            get { return new float4(x, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xzzz
        {
            
            get { return new float4(x, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxxx
        {
            
            get { return new float4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxxy
        {
            
            get { return new float4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxxz
        {
            
            get { return new float4(y, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxyx
        {
            
            get { return new float4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxyy
        {
            
            get { return new float4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxyz
        {
            
            get { return new float4(y, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxzx
        {
            
            get { return new float4(y, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxzy
        {
            
            get { return new float4(y, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxzz
        {
            
            get { return new float4(y, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyxx
        {
            
            get { return new float4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyxy
        {
            
            get { return new float4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyxz
        {
            
            get { return new float4(y, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyyx
        {
            
            get { return new float4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyyy
        {
            
            get { return new float4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyyz
        {
            
            get { return new float4(y, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyzx
        {
            
            get { return new float4(y, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyzy
        {
            
            get { return new float4(y, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyzz
        {
            
            get { return new float4(y, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yzxx
        {
            
            get { return new float4(y, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yzxy
        {
            
            get { return new float4(y, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yzxz
        {
            
            get { return new float4(y, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yzyx
        {
            
            get { return new float4(y, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yzyy
        {
            
            get { return new float4(y, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yzyz
        {
            
            get { return new float4(y, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yzzx
        {
            
            get { return new float4(y, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yzzy
        {
            
            get { return new float4(y, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yzzz
        {
            
            get { return new float4(y, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zxxx
        {
            
            get { return new float4(z, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zxxy
        {
            
            get { return new float4(z, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zxxz
        {
            
            get { return new float4(z, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zxyx
        {
            
            get { return new float4(z, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zxyy
        {
            
            get { return new float4(z, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zxyz
        {
            
            get { return new float4(z, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zxzx
        {
            
            get { return new float4(z, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zxzy
        {
            
            get { return new float4(z, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zxzz
        {
            
            get { return new float4(z, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zyxx
        {
            
            get { return new float4(z, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zyxy
        {
            
            get { return new float4(z, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zyxz
        {
            
            get { return new float4(z, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zyyx
        {
            
            get { return new float4(z, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zyyy
        {
            
            get { return new float4(z, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zyyz
        {
            
            get { return new float4(z, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zyzx
        {
            
            get { return new float4(z, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zyzy
        {
            
            get { return new float4(z, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zyzz
        {
            
            get { return new float4(z, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zzxx
        {
            
            get { return new float4(z, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zzxy
        {
            
            get { return new float4(z, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zzxz
        {
            
            get { return new float4(z, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zzyx
        {
            
            get { return new float4(z, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zzyy
        {
            
            get { return new float4(z, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zzyz
        {
            
            get { return new float4(z, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zzzx
        {
            
            get { return new float4(z, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zzzy
        {
            
            get { return new float4(z, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zzzz
        {
            
            get { return new float4(z, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xxx
        {
            
            get { return new float3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xxy
        {
            
            get { return new float3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xxz
        {
            
            get { return new float3(x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xyx
        {
            
            get { return new float3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xyy
        {
            
            get { return new float3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xyz
        {
            
            get { return new float3(x, y, z); }
            
            set { x = value.x; y = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xzx
        {
            
            get { return new float3(x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xzy
        {
            
            get { return new float3(x, z, y); }
            
            set { x = value.x; z = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xzz
        {
            
            get { return new float3(x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yxx
        {
            
            get { return new float3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yxy
        {
            
            get { return new float3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yxz
        {
            
            get { return new float3(y, x, z); }
            
            set { y = value.x; x = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yyx
        {
            
            get { return new float3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yyy
        {
            
            get { return new float3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yyz
        {
            
            get { return new float3(y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yzx
        {
            
            get { return new float3(y, z, x); }
            
            set { y = value.x; z = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yzy
        {
            
            get { return new float3(y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yzz
        {
            
            get { return new float3(y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 zxx
        {
            
            get { return new float3(z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 zxy
        {
            
            get { return new float3(z, x, y); }
            
            set { z = value.x; x = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 zxz
        {
            
            get { return new float3(z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 zyx
        {
            
            get { return new float3(z, y, x); }
            
            set { z = value.x; y = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 zyy
        {
            
            get { return new float3(z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 zyz
        {
            
            get { return new float3(z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 zzx
        {
            
            get { return new float3(z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 zzy
        {
            
            get { return new float3(z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 zzz
        {
            
            get { return new float3(z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 xx
        {
            
            get { return new float2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 xy
        {
            
            get { return new float2(x, y); }
            
            set { x = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 xz
        {
            
            get { return new float2(x, z); }
            
            set { x = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 yx
        {
            
            get { return new float2(y, x); }
            
            set { y = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 yy
        {
            
            get { return new float2(y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 yz
        {
            
            get { return new float2(y, z); }
            
            set { y = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 zx
        {
            
            get { return new float2(z, x); }
            
            set { z = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 zy
        {
            
            get { return new float2(z, y); }
            
            set { z = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 zz
        {
            
            get { return new float2(z, z); }
        }



        /// <summary>Returns the float element at a specified index.</summary>
        unsafe public float this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (float3* array = &this) { return ((float*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (float* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the float3 is equal to a given float3, false otherwise.</summary>
        
        public bool Equals(float3 rhs) { return x == rhs.x && y == rhs.y && z == rhs.z; }

        /// <summary>Returns true if the float3 is equal to a given float3, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((float3)o); }


        /// <summary>Returns a hash code for the float3.</summary>
        
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the float3.</summary>
        
        public override string ToString()
        {
            return string.Format("float3({0}f, {1}f, {2}f)", x, y, z);
        }

        /// <summary>Returns a string representation of the float3 using a specified format and culture-specific format information.</summary>
        
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("float3({0}f, {1}f, {2}f)", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public float x;
            public float y;
            public float z;
            public DebuggerProxy(float3 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
            }
        }

    }

    public static partial class math
    {
        /// <summary>Returns a float3 vector constructed from three float values.</summary>
        
        public static float3 float3(float x, float y, float z) { return new float3(x, y, z); }

        /// <summary>Returns a float3 vector constructed from a float value and a float2 vector.</summary>
        
        public static float3 float3(float x, float2 yz) { return new float3(x, yz); }

        /// <summary>Returns a float3 vector constructed from a float2 vector and a float value.</summary>
        
        public static float3 float3(float2 xy, float z) { return new float3(xy, z); }

        /// <summary>Returns a float3 vector constructed from a float3 vector.</summary>
        
        public static float3 float3(float3 xyz) { return new float3(xyz); }

        /// <summary>Returns a float3 vector constructed from a single float value by assigning it to every component.</summary>
        
        public static float3 float3(float v) { return new float3(v); }

        /// <summary>Returns a float3 vector constructed from a single bool value by converting it to float and assigning it to every component.</summary>
        
        public static float3 float3(bool v) { return new float3(v); }

        /// <summary>Return a float3 vector constructed from a bool3 vector by componentwise conversion.</summary>
        
        public static float3 float3(bool3 v) { return new float3(v); }

        /// <summary>Returns a float3 vector constructed from a single int value by converting it to float and assigning it to every component.</summary>
        
        public static float3 float3(int v) { return new float3(v); }

        /// <summary>Return a float3 vector constructed from a int3 vector by componentwise conversion.</summary>
        
        public static float3 float3(int3 v) { return new float3(v); }

        /// <summary>Returns a float3 vector constructed from a single uint value by converting it to float and assigning it to every component.</summary>
        
        public static float3 float3(uint v) { return new float3(v); }

        /// <summary>Return a float3 vector constructed from a uint3 vector by componentwise conversion.</summary>
        
        public static float3 float3(uint3 v) { return new float3(v); }

        /// <summary>Returns a float3 vector constructed from a single half value by converting it to float and assigning it to every component.</summary>
        
        public static float3 float3(half v) { return new float3(v); }

        /// <summary>Return a float3 vector constructed from a half3 vector by componentwise conversion.</summary>
        
        public static float3 float3(half3 v) { return new float3(v); }

        /// <summary>Returns a float3 vector constructed from a single double value by converting it to float and assigning it to every component.</summary>
        
        public static float3 float3(double v) { return new float3(v); }

        /// <summary>Return a float3 vector constructed from a double3 vector by componentwise conversion.</summary>
        
        public static float3 float3(double3 v) { return new float3(v); }

        /// <summary>Returns a uint hash code of a float3 vector.</summary>
        
        public static uint hash(float3 v)
        {
            return csum(asuint(v) * uint3(0x9B13B92Du, 0x4ABF0813u, 0x86068063u)) + 0xD75513F9u;
        }

        /// <summary>
        /// Returns a uint3 vector hash code of a float3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        
        public static uint3 hashwide(float3 v)
        {
            return (asuint(v) * uint3(0x5AB3E8CDu, 0x676E8407u, 0xB36DE767u)) + 0x6FCA387Du;
        }

        /// <summary>Returns the result of specified shuffling of the components from two float3 vectors into a float value.</summary>
        
        public static float shuffle(float3 a, float3 b, ShuffleComponent x)
        {
            return select_shuffle_component(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two float3 vectors into a float2 vector.</summary>
        
        public static float2 shuffle(float3 a, float3 b, ShuffleComponent x, ShuffleComponent y)
        {
            return float2(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two float3 vectors into a float3 vector.</summary>
        
        public static float3 shuffle(float3 a, float3 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return float3(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two float3 vectors into a float4 vector.</summary>
        
        public static float4 shuffle(float3 a, float3 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return float4(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z),
                select_shuffle_component(a, b, w));
        }

        
        internal static float select_shuffle_component(float3 a, float3 b, ShuffleComponent component)
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

// GENERATED CODE
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(float2.DebuggerProxy))]
    [System.Serializable]
    public partial struct float2 : System.IEquatable<float2>, IFormattable
    {
        public float x;
        public float y;

        /// <summary>float2 zero value.</summary>
        public static readonly float2 zero;

        /// <summary>Constructs a float2 vector from two float values.</summary>
        
        public float2(float x, float y)
        { 
            this.x = x;
            this.y = y;
        }

        /// <summary>Constructs a float2 vector from a float2 vector.</summary>
        
        public float2(float2 xy)
        { 
            this.x = xy.x;
            this.y = xy.y;
        }

        /// <summary>Constructs a float2 vector from a single float value by assigning it to every component.</summary>
        
        public float2(float v)
        {
            this.x = v;
            this.y = v;
        }

        /// <summary>Constructs a float2 vector from a single bool value by converting it to float and assigning it to every component.</summary>
        
        public float2(bool v)
        {
            this.x = v ? 1.0f : 0.0f;
            this.y = v ? 1.0f : 0.0f;
        }

        /// <summary>Constructs a float2 vector from a bool2 vector by componentwise conversion.</summary>
        
        public float2(bool2 v)
        {
            this.x = v.x ? 1.0f : 0.0f;
            this.y = v.y ? 1.0f : 0.0f;
        }

        /// <summary>Constructs a float2 vector from a single int value by converting it to float and assigning it to every component.</summary>
        
        public float2(int v)
        {
            this.x = v;
            this.y = v;
        }

        /// <summary>Constructs a float2 vector from a int2 vector by componentwise conversion.</summary>
        
        public float2(int2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }

        /// <summary>Constructs a float2 vector from a single uint value by converting it to float and assigning it to every component.</summary>
        
        public float2(uint v)
        {
            this.x = v;
            this.y = v;
        }

        /// <summary>Constructs a float2 vector from a uint2 vector by componentwise conversion.</summary>
        
        public float2(uint2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }

        /// <summary>Constructs a float2 vector from a single half value by converting it to float and assigning it to every component.</summary>
        
        public float2(half v)
        {
            this.x = v;
            this.y = v;
        }

        /// <summary>Constructs a float2 vector from a half2 vector by componentwise conversion.</summary>
        
        public float2(half2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }

        /// <summary>Constructs a float2 vector from a single double value by converting it to float and assigning it to every component.</summary>
        
        public float2(double v)
        {
            this.x = (float)v;
            this.y = (float)v;
        }

        /// <summary>Constructs a float2 vector from a double2 vector by componentwise conversion.</summary>
        
        public float2(double2 v)
        {
            this.x = (float)v.x;
            this.y = (float)v.y;
        }


        /// <summary>Implicitly converts a single float value to a float2 vector by assigning it to every component.</summary>
        
        public static implicit operator float2(float v) { return new float2(v); }

        /// <summary>Explicitly converts a single bool value to a float2 vector by converting it to float and assigning it to every component.</summary>
        
        public static explicit operator float2(bool v) { return new float2(v); }

        /// <summary>Explicitly converts a bool2 vector to a float2 vector by componentwise conversion.</summary>
        
        public static explicit operator float2(bool2 v) { return new float2(v); }

        /// <summary>Implicitly converts a single int value to a float2 vector by converting it to float and assigning it to every component.</summary>
        
        public static implicit operator float2(int v) { return new float2(v); }

        /// <summary>Implicitly converts a int2 vector to a float2 vector by componentwise conversion.</summary>
        
        public static implicit operator float2(int2 v) { return new float2(v); }

        /// <summary>Implicitly converts a single uint value to a float2 vector by converting it to float and assigning it to every component.</summary>
        
        public static implicit operator float2(uint v) { return new float2(v); }

        /// <summary>Implicitly converts a uint2 vector to a float2 vector by componentwise conversion.</summary>
        
        public static implicit operator float2(uint2 v) { return new float2(v); }

        /// <summary>Implicitly converts a single half value to a float2 vector by converting it to float and assigning it to every component.</summary>
        
        public static implicit operator float2(half v) { return new float2(v); }

        /// <summary>Implicitly converts a half2 vector to a float2 vector by componentwise conversion.</summary>
        
        public static implicit operator float2(half2 v) { return new float2(v); }

        /// <summary>Explicitly converts a single double value to a float2 vector by converting it to float and assigning it to every component.</summary>
        
        public static explicit operator float2(double v) { return new float2(v); }

        /// <summary>Explicitly converts a double2 vector to a float2 vector by componentwise conversion.</summary>
        
        public static explicit operator float2(double2 v) { return new float2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two float2 vectors.</summary>
        
        public static float2 operator * (float2 lhs, float2 rhs) { return new float2 (lhs.x * rhs.x, lhs.y * rhs.y); }

        /// <summary>Returns the result of a componentwise multiplication operation on a float2 vector and a float value.</summary>
        
        public static float2 operator * (float2 lhs, float rhs) { return new float2 (lhs.x * rhs, lhs.y * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a float value and a float2 vector.</summary>
        
        public static float2 operator * (float lhs, float2 rhs) { return new float2 (lhs * rhs.x, lhs * rhs.y); }


        /// <summary>Returns the result of a componentwise addition operation on two float2 vectors.</summary>
        
        public static float2 operator + (float2 lhs, float2 rhs) { return new float2 (lhs.x + rhs.x, lhs.y + rhs.y); }

        /// <summary>Returns the result of a componentwise addition operation on a float2 vector and a float value.</summary>
        
        public static float2 operator + (float2 lhs, float rhs) { return new float2 (lhs.x + rhs, lhs.y + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a float value and a float2 vector.</summary>
        
        public static float2 operator + (float lhs, float2 rhs) { return new float2 (lhs + rhs.x, lhs + rhs.y); }


        /// <summary>Returns the result of a componentwise subtraction operation on two float2 vectors.</summary>
        
        public static float2 operator - (float2 lhs, float2 rhs) { return new float2 (lhs.x - rhs.x, lhs.y - rhs.y); }

        /// <summary>Returns the result of a componentwise subtraction operation on a float2 vector and a float value.</summary>
        
        public static float2 operator - (float2 lhs, float rhs) { return new float2 (lhs.x - rhs, lhs.y - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a float value and a float2 vector.</summary>
        
        public static float2 operator - (float lhs, float2 rhs) { return new float2 (lhs - rhs.x, lhs - rhs.y); }


        /// <summary>Returns the result of a componentwise division operation on two float2 vectors.</summary>
        
        public static float2 operator / (float2 lhs, float2 rhs) { return new float2 (lhs.x / rhs.x, lhs.y / rhs.y); }

        /// <summary>Returns the result of a componentwise division operation on a float2 vector and a float value.</summary>
        
        public static float2 operator / (float2 lhs, float rhs) { return new float2 (lhs.x / rhs, lhs.y / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a float value and a float2 vector.</summary>
        
        public static float2 operator / (float lhs, float2 rhs) { return new float2 (lhs / rhs.x, lhs / rhs.y); }


        /// <summary>Returns the result of a componentwise modulus operation on two float2 vectors.</summary>
        
        public static float2 operator % (float2 lhs, float2 rhs) { return new float2 (lhs.x % rhs.x, lhs.y % rhs.y); }

        /// <summary>Returns the result of a componentwise modulus operation on a float2 vector and a float value.</summary>
        
        public static float2 operator % (float2 lhs, float rhs) { return new float2 (lhs.x % rhs, lhs.y % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a float value and a float2 vector.</summary>
        
        public static float2 operator % (float lhs, float2 rhs) { return new float2 (lhs % rhs.x, lhs % rhs.y); }


        /// <summary>Returns the result of a componentwise increment operation on a float2 vector.</summary>
        
        public static float2 operator ++ (float2 val) { return new float2 (++val.x, ++val.y); }


        /// <summary>Returns the result of a componentwise decrement operation on a float2 vector.</summary>
        
        public static float2 operator -- (float2 val) { return new float2 (--val.x, --val.y); }


        /// <summary>Returns the result of a componentwise less than operation on two float2 vectors.</summary>
        
        public static bool2 operator < (float2 lhs, float2 rhs) { return new bool2 (lhs.x < rhs.x, lhs.y < rhs.y); }

        /// <summary>Returns the result of a componentwise less than operation on a float2 vector and a float value.</summary>
        
        public static bool2 operator < (float2 lhs, float rhs) { return new bool2 (lhs.x < rhs, lhs.y < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a float value and a float2 vector.</summary>
        
        public static bool2 operator < (float lhs, float2 rhs) { return new bool2 (lhs < rhs.x, lhs < rhs.y); }


        /// <summary>Returns the result of a componentwise less or equal operation on two float2 vectors.</summary>
        
        public static bool2 operator <= (float2 lhs, float2 rhs) { return new bool2 (lhs.x <= rhs.x, lhs.y <= rhs.y); }

        /// <summary>Returns the result of a componentwise less or equal operation on a float2 vector and a float value.</summary>
        
        public static bool2 operator <= (float2 lhs, float rhs) { return new bool2 (lhs.x <= rhs, lhs.y <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a float value and a float2 vector.</summary>
        
        public static bool2 operator <= (float lhs, float2 rhs) { return new bool2 (lhs <= rhs.x, lhs <= rhs.y); }


        /// <summary>Returns the result of a componentwise greater than operation on two float2 vectors.</summary>
        
        public static bool2 operator > (float2 lhs, float2 rhs) { return new bool2 (lhs.x > rhs.x, lhs.y > rhs.y); }

        /// <summary>Returns the result of a componentwise greater than operation on a float2 vector and a float value.</summary>
        
        public static bool2 operator > (float2 lhs, float rhs) { return new bool2 (lhs.x > rhs, lhs.y > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a float value and a float2 vector.</summary>
        
        public static bool2 operator > (float lhs, float2 rhs) { return new bool2 (lhs > rhs.x, lhs > rhs.y); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two float2 vectors.</summary>
        
        public static bool2 operator >= (float2 lhs, float2 rhs) { return new bool2 (lhs.x >= rhs.x, lhs.y >= rhs.y); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float2 vector and a float value.</summary>
        
        public static bool2 operator >= (float2 lhs, float rhs) { return new bool2 (lhs.x >= rhs, lhs.y >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float value and a float2 vector.</summary>
        
        public static bool2 operator >= (float lhs, float2 rhs) { return new bool2 (lhs >= rhs.x, lhs >= rhs.y); }


        /// <summary>Returns the result of a componentwise unary minus operation on a float2 vector.</summary>
        
        public static float2 operator - (float2 val) { return new float2 (-val.x, -val.y); }


        /// <summary>Returns the result of a componentwise unary plus operation on a float2 vector.</summary>
        
        public static float2 operator + (float2 val) { return new float2 (+val.x, +val.y); }


        /// <summary>Returns the result of a componentwise equality operation on two float2 vectors.</summary>
        
        public static bool2 operator == (float2 lhs, float2 rhs) { return new bool2 (lhs.x == rhs.x, lhs.y == rhs.y); }

        /// <summary>Returns the result of a componentwise equality operation on a float2 vector and a float value.</summary>
        
        public static bool2 operator == (float2 lhs, float rhs) { return new bool2 (lhs.x == rhs, lhs.y == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a float value and a float2 vector.</summary>
        
        public static bool2 operator == (float lhs, float2 rhs) { return new bool2 (lhs == rhs.x, lhs == rhs.y); }


        /// <summary>Returns the result of a componentwise not equal operation on two float2 vectors.</summary>
        
        public static bool2 operator != (float2 lhs, float2 rhs) { return new bool2 (lhs.x != rhs.x, lhs.y != rhs.y); }

        /// <summary>Returns the result of a componentwise not equal operation on a float2 vector and a float value.</summary>
        
        public static bool2 operator != (float2 lhs, float rhs) { return new bool2 (lhs.x != rhs, lhs.y != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a float value and a float2 vector.</summary>
        
        public static bool2 operator != (float lhs, float2 rhs) { return new bool2 (lhs != rhs.x, lhs != rhs.y); }




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



        /// <summary>Returns the float element at a specified index.</summary>
        unsafe public float this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (float2* array = &this) { return ((float*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (float* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the float2 is equal to a given float2, false otherwise.</summary>
        
        public bool Equals(float2 rhs) { return x == rhs.x && y == rhs.y; }

        /// <summary>Returns true if the float2 is equal to a given float2, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((float2)o); }


        /// <summary>Returns a hash code for the float2.</summary>
        
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the float2.</summary>
        
        public override string ToString()
        {
            return string.Format("float2({0}f, {1}f)", x, y);
        }

        /// <summary>Returns a string representation of the float2 using a specified format and culture-specific format information.</summary>
        
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("float2({0}f, {1}f)", x.ToString(format, formatProvider), y.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public float x;
            public float y;
            public DebuggerProxy(float2 v)
            {
                x = v.x;
                y = v.y;
            }
        }

    }

    public static partial class math
    {
        /// <summary>Returns a float2 vector constructed from two float values.</summary>
        
        public static float2 float2(float x, float y) { return new float2(x, y); }

        /// <summary>Returns a float2 vector constructed from a float2 vector.</summary>
        
        public static float2 float2(float2 xy) { return new float2(xy); }

        /// <summary>Returns a float2 vector constructed from a single float value by assigning it to every component.</summary>
        
        public static float2 float2(float v) { return new float2(v); }

        /// <summary>Returns a float2 vector constructed from a single bool value by converting it to float and assigning it to every component.</summary>
        
        public static float2 float2(bool v) { return new float2(v); }

        /// <summary>Return a float2 vector constructed from a bool2 vector by componentwise conversion.</summary>
        
        public static float2 float2(bool2 v) { return new float2(v); }

        /// <summary>Returns a float2 vector constructed from a single int value by converting it to float and assigning it to every component.</summary>
        
        public static float2 float2(int v) { return new float2(v); }

        /// <summary>Return a float2 vector constructed from a int2 vector by componentwise conversion.</summary>
        
        public static float2 float2(int2 v) { return new float2(v); }

        /// <summary>Returns a float2 vector constructed from a single uint value by converting it to float and assigning it to every component.</summary>
        
        public static float2 float2(uint v) { return new float2(v); }

        /// <summary>Return a float2 vector constructed from a uint2 vector by componentwise conversion.</summary>
        
        public static float2 float2(uint2 v) { return new float2(v); }

        /// <summary>Returns a float2 vector constructed from a single half value by converting it to float and assigning it to every component.</summary>
        
        public static float2 float2(half v) { return new float2(v); }

        /// <summary>Return a float2 vector constructed from a half2 vector by componentwise conversion.</summary>
        
        public static float2 float2(half2 v) { return new float2(v); }

        /// <summary>Returns a float2 vector constructed from a single double value by converting it to float and assigning it to every component.</summary>
        
        public static float2 float2(double v) { return new float2(v); }

        /// <summary>Return a float2 vector constructed from a double2 vector by componentwise conversion.</summary>
        
        public static float2 float2(double2 v) { return new float2(v); }

        /// <summary>Returns a uint hash code of a float2 vector.</summary>
        
        public static uint hash(float2 v)
        {
            return csum(asuint(v) * uint2(0xFA3A3285u, 0xAD55999Du)) + 0xDCDD5341u;
        }

        /// <summary>
        /// Returns a uint2 vector hash code of a float2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        
        public static uint2 hashwide(float2 v)
        {
            return (asuint(v) * uint2(0x94DDD769u, 0xA1E92D39u)) + 0x4583C801u;
        }

        /// <summary>Returns the result of specified shuffling of the components from two float2 vectors into a float value.</summary>
        
        public static float shuffle(float2 a, float2 b, ShuffleComponent x)
        {
            return select_shuffle_component(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two float2 vectors into a float2 vector.</summary>
        
        public static float2 shuffle(float2 a, float2 b, ShuffleComponent x, ShuffleComponent y)
        {
            return float2(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two float2 vectors into a float3 vector.</summary>
        
        public static float3 shuffle(float2 a, float2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return float3(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two float2 vectors into a float4 vector.</summary>
        
        public static float4 shuffle(float2 a, float2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return float4(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z),
                select_shuffle_component(a, b, w));
        }

        
        internal static float select_shuffle_component(float2 a, float2 b, ShuffleComponent component)
        {
            switch(component)
            {
                case ShuffleComponent.LeftX:
                    return a.x;
                case ShuffleComponent.LeftY:
                    return a.y;
                case ShuffleComponent.RightX:
                    return b.x;
                case ShuffleComponent.RightY:
                    return b.y;
                default:
                    throw new System.ArgumentException("Invalid shuffle component: " + component);
            }
        }

    }
}

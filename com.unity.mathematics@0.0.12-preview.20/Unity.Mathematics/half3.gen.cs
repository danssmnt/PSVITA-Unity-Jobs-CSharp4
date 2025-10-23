// GENERATED CODE
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(half3.DebuggerProxy))]
    public partial struct half3 : System.IEquatable<half3>, IFormattable
    {
        public half x;
        public half y;
        public half z;

        /// <summary>half3 zero value.</summary>
        public static readonly half3 zero;

        /// <summary>Constructs a half3 vector from three half values.</summary>
        
        public half3(half x, half y, half z)
        { 
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>Constructs a half3 vector from a half value and a half2 vector.</summary>
        
        public half3(half x, half2 yz)
        { 
            this.x = x;
            this.y = yz.x;
            this.z = yz.y;
        }

        /// <summary>Constructs a half3 vector from a half2 vector and a half value.</summary>
        
        public half3(half2 xy, half z)
        { 
            this.x = xy.x;
            this.y = xy.y;
            this.z = z;
        }

        /// <summary>Constructs a half3 vector from a half3 vector.</summary>
        
        public half3(half3 xyz)
        { 
            this.x = xyz.x;
            this.y = xyz.y;
            this.z = xyz.z;
        }

        /// <summary>Constructs a half3 vector from a single half value by assigning it to every component.</summary>
        
        public half3(half v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }

        /// <summary>Constructs a half3 vector from a single float value by converting it to half and assigning it to every component.</summary>
        
        public half3(float v)
        {
            this.x = (half)v;
            this.y = (half)v;
            this.z = (half)v;
        }

        /// <summary>Constructs a half3 vector from a float3 vector by componentwise conversion.</summary>
        
        public half3(float3 v)
        {
            this.x = (half)v.x;
            this.y = (half)v.y;
            this.z = (half)v.z;
        }

        /// <summary>Constructs a half3 vector from a single double value by converting it to half and assigning it to every component.</summary>
        
        public half3(double v)
        {
            this.x = (half)v;
            this.y = (half)v;
            this.z = (half)v;
        }

        /// <summary>Constructs a half3 vector from a double3 vector by componentwise conversion.</summary>
        
        public half3(double3 v)
        {
            this.x = (half)v.x;
            this.y = (half)v.y;
            this.z = (half)v.z;
        }


        /// <summary>Implicitly converts a single half value to a half3 vector by assigning it to every component.</summary>
        
        public static implicit operator half3(half v) { return new half3(v); }

        /// <summary>Explicitly converts a single float value to a half3 vector by converting it to half and assigning it to every component.</summary>
        
        public static explicit operator half3(float v) { return new half3(v); }

        /// <summary>Explicitly converts a float3 vector to a half3 vector by componentwise conversion.</summary>
        
        public static explicit operator half3(float3 v) { return new half3(v); }

        /// <summary>Explicitly converts a single double value to a half3 vector by converting it to half and assigning it to every component.</summary>
        
        public static explicit operator half3(double v) { return new half3(v); }

        /// <summary>Explicitly converts a double3 vector to a half3 vector by componentwise conversion.</summary>
        
        public static explicit operator half3(double3 v) { return new half3(v); }


        /// <summary>Returns the result of a componentwise equality operation on two half3 vectors.</summary>
        
        public static bool3 operator == (half3 lhs, half3 rhs) { return new bool3 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z); }

        /// <summary>Returns the result of a componentwise equality operation on a half3 vector and a half value.</summary>
        
        public static bool3 operator == (half3 lhs, half rhs) { return new bool3 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a half value and a half3 vector.</summary>
        
        public static bool3 operator == (half lhs, half3 rhs) { return new bool3 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z); }


        /// <summary>Returns the result of a componentwise not equal operation on two half3 vectors.</summary>
        
        public static bool3 operator != (half3 lhs, half3 rhs) { return new bool3 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z); }

        /// <summary>Returns the result of a componentwise not equal operation on a half3 vector and a half value.</summary>
        
        public static bool3 operator != (half3 lhs, half rhs) { return new bool3 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a half value and a half3 vector.</summary>
        
        public static bool3 operator != (half lhs, half3 rhs) { return new bool3 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z); }




        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xxxx
        {
            
            get { return new half4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xxxy
        {
            
            get { return new half4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xxxz
        {
            
            get { return new half4(x, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xxyx
        {
            
            get { return new half4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xxyy
        {
            
            get { return new half4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xxyz
        {
            
            get { return new half4(x, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xxzx
        {
            
            get { return new half4(x, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xxzy
        {
            
            get { return new half4(x, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xxzz
        {
            
            get { return new half4(x, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xyxx
        {
            
            get { return new half4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xyxy
        {
            
            get { return new half4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xyxz
        {
            
            get { return new half4(x, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xyyx
        {
            
            get { return new half4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xyyy
        {
            
            get { return new half4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xyyz
        {
            
            get { return new half4(x, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xyzx
        {
            
            get { return new half4(x, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xyzy
        {
            
            get { return new half4(x, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xyzz
        {
            
            get { return new half4(x, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xzxx
        {
            
            get { return new half4(x, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xzxy
        {
            
            get { return new half4(x, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xzxz
        {
            
            get { return new half4(x, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xzyx
        {
            
            get { return new half4(x, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xzyy
        {
            
            get { return new half4(x, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xzyz
        {
            
            get { return new half4(x, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xzzx
        {
            
            get { return new half4(x, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xzzy
        {
            
            get { return new half4(x, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 xzzz
        {
            
            get { return new half4(x, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yxxx
        {
            
            get { return new half4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yxxy
        {
            
            get { return new half4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yxxz
        {
            
            get { return new half4(y, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yxyx
        {
            
            get { return new half4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yxyy
        {
            
            get { return new half4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yxyz
        {
            
            get { return new half4(y, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yxzx
        {
            
            get { return new half4(y, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yxzy
        {
            
            get { return new half4(y, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yxzz
        {
            
            get { return new half4(y, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yyxx
        {
            
            get { return new half4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yyxy
        {
            
            get { return new half4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yyxz
        {
            
            get { return new half4(y, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yyyx
        {
            
            get { return new half4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yyyy
        {
            
            get { return new half4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yyyz
        {
            
            get { return new half4(y, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yyzx
        {
            
            get { return new half4(y, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yyzy
        {
            
            get { return new half4(y, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yyzz
        {
            
            get { return new half4(y, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yzxx
        {
            
            get { return new half4(y, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yzxy
        {
            
            get { return new half4(y, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yzxz
        {
            
            get { return new half4(y, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yzyx
        {
            
            get { return new half4(y, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yzyy
        {
            
            get { return new half4(y, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yzyz
        {
            
            get { return new half4(y, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yzzx
        {
            
            get { return new half4(y, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yzzy
        {
            
            get { return new half4(y, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 yzzz
        {
            
            get { return new half4(y, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zxxx
        {
            
            get { return new half4(z, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zxxy
        {
            
            get { return new half4(z, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zxxz
        {
            
            get { return new half4(z, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zxyx
        {
            
            get { return new half4(z, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zxyy
        {
            
            get { return new half4(z, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zxyz
        {
            
            get { return new half4(z, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zxzx
        {
            
            get { return new half4(z, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zxzy
        {
            
            get { return new half4(z, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zxzz
        {
            
            get { return new half4(z, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zyxx
        {
            
            get { return new half4(z, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zyxy
        {
            
            get { return new half4(z, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zyxz
        {
            
            get { return new half4(z, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zyyx
        {
            
            get { return new half4(z, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zyyy
        {
            
            get { return new half4(z, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zyyz
        {
            
            get { return new half4(z, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zyzx
        {
            
            get { return new half4(z, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zyzy
        {
            
            get { return new half4(z, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zyzz
        {
            
            get { return new half4(z, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zzxx
        {
            
            get { return new half4(z, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zzxy
        {
            
            get { return new half4(z, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zzxz
        {
            
            get { return new half4(z, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zzyx
        {
            
            get { return new half4(z, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zzyy
        {
            
            get { return new half4(z, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zzyz
        {
            
            get { return new half4(z, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zzzx
        {
            
            get { return new half4(z, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zzzy
        {
            
            get { return new half4(z, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half4 zzzz
        {
            
            get { return new half4(z, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 xxx
        {
            
            get { return new half3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 xxy
        {
            
            get { return new half3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 xxz
        {
            
            get { return new half3(x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 xyx
        {
            
            get { return new half3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 xyy
        {
            
            get { return new half3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 xyz
        {
            
            get { return new half3(x, y, z); }
            
            set { x = value.x; y = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 xzx
        {
            
            get { return new half3(x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 xzy
        {
            
            get { return new half3(x, z, y); }
            
            set { x = value.x; z = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 xzz
        {
            
            get { return new half3(x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 yxx
        {
            
            get { return new half3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 yxy
        {
            
            get { return new half3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 yxz
        {
            
            get { return new half3(y, x, z); }
            
            set { y = value.x; x = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 yyx
        {
            
            get { return new half3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 yyy
        {
            
            get { return new half3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 yyz
        {
            
            get { return new half3(y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 yzx
        {
            
            get { return new half3(y, z, x); }
            
            set { y = value.x; z = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 yzy
        {
            
            get { return new half3(y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 yzz
        {
            
            get { return new half3(y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 zxx
        {
            
            get { return new half3(z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 zxy
        {
            
            get { return new half3(z, x, y); }
            
            set { z = value.x; x = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 zxz
        {
            
            get { return new half3(z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 zyx
        {
            
            get { return new half3(z, y, x); }
            
            set { z = value.x; y = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 zyy
        {
            
            get { return new half3(z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 zyz
        {
            
            get { return new half3(z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 zzx
        {
            
            get { return new half3(z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 zzy
        {
            
            get { return new half3(z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half3 zzz
        {
            
            get { return new half3(z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half2 xx
        {
            
            get { return new half2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half2 xy
        {
            
            get { return new half2(x, y); }
            
            set { x = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half2 xz
        {
            
            get { return new half2(x, z); }
            
            set { x = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half2 yx
        {
            
            get { return new half2(y, x); }
            
            set { y = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half2 yy
        {
            
            get { return new half2(y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half2 yz
        {
            
            get { return new half2(y, z); }
            
            set { y = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half2 zx
        {
            
            get { return new half2(z, x); }
            
            set { z = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half2 zy
        {
            
            get { return new half2(z, y); }
            
            set { z = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public half2 zz
        {
            
            get { return new half2(z, z); }
        }



        /// <summary>Returns the half element at a specified index.</summary>
        unsafe public half this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (half3* array = &this) { return ((half*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (half* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the half3 is equal to a given half3, false otherwise.</summary>
        
        public bool Equals(half3 rhs) { return x == rhs.x && y == rhs.y && z == rhs.z; }

        /// <summary>Returns true if the half3 is equal to a given half3, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((half3)o); }


        /// <summary>Returns a hash code for the half3.</summary>
        
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the half3.</summary>
        
        public override string ToString()
        {
            return string.Format("half3({0}, {1}, {2})", x, y, z);
        }

        /// <summary>Returns a string representation of the half3 using a specified format and culture-specific format information.</summary>
        
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("half3({0}, {1}, {2})", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public half x;
            public half y;
            public half z;
            public DebuggerProxy(half3 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
            }
        }

    }

    public static partial class math
    {
        /// <summary>Returns a half3 vector constructed from three half values.</summary>
        
        public static half3 half3(half x, half y, half z) { return new half3(x, y, z); }

        /// <summary>Returns a half3 vector constructed from a half value and a half2 vector.</summary>
        
        public static half3 half3(half x, half2 yz) { return new half3(x, yz); }

        /// <summary>Returns a half3 vector constructed from a half2 vector and a half value.</summary>
        
        public static half3 half3(half2 xy, half z) { return new half3(xy, z); }

        /// <summary>Returns a half3 vector constructed from a half3 vector.</summary>
        
        public static half3 half3(half3 xyz) { return new half3(xyz); }

        /// <summary>Returns a half3 vector constructed from a single half value by assigning it to every component.</summary>
        
        public static half3 half3(half v) { return new half3(v); }

        /// <summary>Returns a half3 vector constructed from a single float value by converting it to half and assigning it to every component.</summary>
        
        public static half3 half3(float v) { return new half3(v); }

        /// <summary>Return a half3 vector constructed from a float3 vector by componentwise conversion.</summary>
        
        public static half3 half3(float3 v) { return new half3(v); }

        /// <summary>Returns a half3 vector constructed from a single double value by converting it to half and assigning it to every component.</summary>
        
        public static half3 half3(double v) { return new half3(v); }

        /// <summary>Return a half3 vector constructed from a double3 vector by componentwise conversion.</summary>
        
        public static half3 half3(double3 v) { return new half3(v); }

        /// <summary>Returns a uint hash code of a half3 vector.</summary>
        
        public static uint hash(half3 v)
        {
            return csum(uint3(v.x.value, v.y.value, v.z.value) * uint3(0x685835CFu, 0xC3D32AE1u, 0xB966942Fu)) + 0xFE9856B3u;
        }

        /// <summary>
        /// Returns a uint3 vector hash code of a half3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        
        public static uint3 hashwide(half3 v)
        {
            return (uint3(v.x.value, v.y.value, v.z.value) * uint3(0xFA3A3285u, 0xAD55999Du, 0xDCDD5341u)) + 0x94DDD769u;
        }

    }
}

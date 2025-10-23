// GENERATED CODE
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(bool2.DebuggerProxy))]
    [System.Serializable]
    public partial struct bool2 : System.IEquatable<bool2>
    {
        [MarshalAs(UnmanagedType.U1)]
        public bool x;
        [MarshalAs(UnmanagedType.U1)]
        public bool y;


        /// <summary>Constructs a bool2 vector from two bool values.</summary>
        
        public bool2(bool x, bool y)
        { 
            this.x = x;
            this.y = y;
        }

        /// <summary>Constructs a bool2 vector from a bool2 vector.</summary>
        
        public bool2(bool2 xy)
        { 
            this.x = xy.x;
            this.y = xy.y;
        }

        /// <summary>Constructs a bool2 vector from a single bool value by assigning it to every component.</summary>
        
        public bool2(bool v)
        {
            this.x = v;
            this.y = v;
        }


        /// <summary>Implicitly converts a single bool value to a bool2 vector by assigning it to every component.</summary>
        
        public static implicit operator bool2(bool v) { return new bool2(v); }


        /// <summary>Returns the result of a componentwise equality operation on two bool2 vectors.</summary>
        
        public static bool2 operator == (bool2 lhs, bool2 rhs) { return new bool2 (lhs.x == rhs.x, lhs.y == rhs.y); }

        /// <summary>Returns the result of a componentwise equality operation on a bool2 vector and a bool value.</summary>
        
        public static bool2 operator == (bool2 lhs, bool rhs) { return new bool2 (lhs.x == rhs, lhs.y == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a bool value and a bool2 vector.</summary>
        
        public static bool2 operator == (bool lhs, bool2 rhs) { return new bool2 (lhs == rhs.x, lhs == rhs.y); }


        /// <summary>Returns the result of a componentwise not equal operation on two bool2 vectors.</summary>
        
        public static bool2 operator != (bool2 lhs, bool2 rhs) { return new bool2 (lhs.x != rhs.x, lhs.y != rhs.y); }

        /// <summary>Returns the result of a componentwise not equal operation on a bool2 vector and a bool value.</summary>
        
        public static bool2 operator != (bool2 lhs, bool rhs) { return new bool2 (lhs.x != rhs, lhs.y != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a bool value and a bool2 vector.</summary>
        
        public static bool2 operator != (bool lhs, bool2 rhs) { return new bool2 (lhs != rhs.x, lhs != rhs.y); }


        /// <summary>Returns the result of a componentwise not operation on a bool2 vector.</summary>
        
        public static bool2 operator ! (bool2 val) { return new bool2 (!val.x, !val.y); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two bool2 vectors.</summary>
        
        public static bool2 operator & (bool2 lhs, bool2 rhs) { return new bool2 (lhs.x & rhs.x, lhs.y & rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool2 vector and a bool value.</summary>
        
        public static bool2 operator & (bool2 lhs, bool rhs) { return new bool2 (lhs.x & rhs, lhs.y & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool value and a bool2 vector.</summary>
        
        public static bool2 operator & (bool lhs, bool2 rhs) { return new bool2 (lhs & rhs.x, lhs & rhs.y); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two bool2 vectors.</summary>
        
        public static bool2 operator | (bool2 lhs, bool2 rhs) { return new bool2 (lhs.x | rhs.x, lhs.y | rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool2 vector and a bool value.</summary>
        
        public static bool2 operator | (bool2 lhs, bool rhs) { return new bool2 (lhs.x | rhs, lhs.y | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool value and a bool2 vector.</summary>
        
        public static bool2 operator | (bool lhs, bool2 rhs) { return new bool2 (lhs | rhs.x, lhs | rhs.y); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two bool2 vectors.</summary>
        
        public static bool2 operator ^ (bool2 lhs, bool2 rhs) { return new bool2 (lhs.x ^ rhs.x, lhs.y ^ rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool2 vector and a bool value.</summary>
        
        public static bool2 operator ^ (bool2 lhs, bool rhs) { return new bool2 (lhs.x ^ rhs, lhs.y ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool value and a bool2 vector.</summary>
        
        public static bool2 operator ^ (bool lhs, bool2 rhs) { return new bool2 (lhs ^ rhs.x, lhs ^ rhs.y); }




        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xxxx
        {
            
            get { return new bool4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xxxy
        {
            
            get { return new bool4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xxyx
        {
            
            get { return new bool4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xxyy
        {
            
            get { return new bool4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xyxx
        {
            
            get { return new bool4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xyxy
        {
            
            get { return new bool4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xyyx
        {
            
            get { return new bool4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xyyy
        {
            
            get { return new bool4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yxxx
        {
            
            get { return new bool4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yxxy
        {
            
            get { return new bool4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yxyx
        {
            
            get { return new bool4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yxyy
        {
            
            get { return new bool4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yyxx
        {
            
            get { return new bool4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yyxy
        {
            
            get { return new bool4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yyyx
        {
            
            get { return new bool4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yyyy
        {
            
            get { return new bool4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 xxx
        {
            
            get { return new bool3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 xxy
        {
            
            get { return new bool3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 xyx
        {
            
            get { return new bool3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 xyy
        {
            
            get { return new bool3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 yxx
        {
            
            get { return new bool3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 yxy
        {
            
            get { return new bool3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 yyx
        {
            
            get { return new bool3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 yyy
        {
            
            get { return new bool3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool2 xx
        {
            
            get { return new bool2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool2 xy
        {
            
            get { return new bool2(x, y); }
            
            set { x = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool2 yx
        {
            
            get { return new bool2(y, x); }
            
            set { y = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool2 yy
        {
            
            get { return new bool2(y, y); }
        }



        /// <summary>Returns the bool element at a specified index.</summary>
        unsafe public bool this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (bool2* array = &this) { return ((bool*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (bool* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the bool2 is equal to a given bool2, false otherwise.</summary>
        
        public bool Equals(bool2 rhs) { return x == rhs.x && y == rhs.y; }

        /// <summary>Returns true if the bool2 is equal to a given bool2, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((bool2)o); }


        /// <summary>Returns a hash code for the bool2.</summary>
        
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the bool2.</summary>
        
        public override string ToString()
        {
            return string.Format("bool2({0}, {1})", x, y);
        }

        internal sealed class DebuggerProxy
        {
            public bool x;
            public bool y;
            public DebuggerProxy(bool2 v)
            {
                x = v.x;
                y = v.y;
            }
        }

    }

    public static partial class math
    {
        /// <summary>Returns a bool2 vector constructed from two bool values.</summary>
        
        public static bool2 bool2(bool x, bool y) { return new bool2(x, y); }

        /// <summary>Returns a bool2 vector constructed from a bool2 vector.</summary>
        
        public static bool2 bool2(bool2 xy) { return new bool2(xy); }

        /// <summary>Returns a bool2 vector constructed from a single bool value by assigning it to every component.</summary>
        
        public static bool2 bool2(bool v) { return new bool2(v); }

        /// <summary>Returns a uint hash code of a bool2 vector.</summary>
        
        public static uint hash(bool2 v)
        {
            return csum(select(uint2(0x90A285BBu, 0x5D19E1D5u), uint2(0xFAAF07DDu, 0x625C45BDu), v));
        }

        /// <summary>
        /// Returns a uint2 vector hash code of a bool2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        
        public static uint2 hashwide(bool2 v)
        {
            return (select(uint2(0xC9F27FCBu, 0x6D2523B1u), uint2(0x6E2BF6A9u, 0xCC74B3B7u), v));
        }

        /// <summary>Returns the result of specified shuffling of the components from two bool2 vectors into a bool value.</summary>
        
        public static bool shuffle(bool2 a, bool2 b, ShuffleComponent x)
        {
            return select_shuffle_component(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two bool2 vectors into a bool2 vector.</summary>
        
        public static bool2 shuffle(bool2 a, bool2 b, ShuffleComponent x, ShuffleComponent y)
        {
            return bool2(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two bool2 vectors into a bool3 vector.</summary>
        
        public static bool3 shuffle(bool2 a, bool2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return bool3(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two bool2 vectors into a bool4 vector.</summary>
        
        public static bool4 shuffle(bool2 a, bool2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return bool4(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z),
                select_shuffle_component(a, b, w));
        }

        
        internal static bool select_shuffle_component(bool2 a, bool2 b, ShuffleComponent component)
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

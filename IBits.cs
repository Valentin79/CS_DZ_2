﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Sem_2
{
    internal interface IBits
    {
        bool GetBit(int i);
        void SetBit(bool bit, int index);
    }


    public class Bits : IBits
    {
        //public byte Value { get; private set; } = 0;

        public Bits(byte b)
        {
            this.Value = b;
            MaxBitsCount = sizeof(byte) * 8;
        }

        public Bits(short b)
        {
            this.Value = b;
            MaxBitsCount = sizeof(short) * 8;
        }

        public Bits(int b)
        {
            this.Value = b;
            MaxBitsCount = sizeof(int) * 8;
        }

        public Bits(long b)
        {
            this.Value = b;
            MaxBitsCount = sizeof(long) * 8;
        }

        public long Value { get; set; } = 0;
        private int MaxBitsCount { get; set; }



        public bool GetBit(int index)
        {
            if (index > MaxBitsCount || index < 0)
            {
                Console.WriteLine($"Выход за пределы от 0 до {MaxBitsCount}");
                return false;
            }

            return ((Value >> index) & 1) == 1;
        }

        public void SetBit(bool bit, int index)
        {
            if (index > MaxBitsCount || index < 0)
            {
                Console.WriteLine($"Выход за пределы от 0 до {MaxBitsCount}");
                return;
            }
            if (bit == true)
                Value = (byte)(Value | (1 << index));
            else
            {
                var mask = (byte)(1 << index);
                mask = (byte)(0xff ^ mask);
                Value &= (byte)(Value & mask);
            }
        }

        public override string ToString()
        {
            return $"{Value}";
        }

        //public static implicit operator byte(Bits b) => b.Value;
        //public static implicit operator byte(Bits b) => new Bits(b.Value);
        //public static implicit operator long(Bits b) => new Bits(b.Value);
        //public static implicit operator int(Bits b) => new Bits(b.Value);

        public static implicit operator Bits(byte b) => new Bits(b);
        public static implicit operator Bits(short b) => new Bits(b);
        public static implicit operator Bits(long b) => new Bits(b);
        public static implicit operator Bits(int b) => new Bits(b);
    }


}

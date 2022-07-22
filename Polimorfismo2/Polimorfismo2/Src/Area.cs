using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo2.Src
{
        class Area
        {
        private double @base;
        private double altura;
        private double lado;

        public double _Base { get; set; }
            public double _Altura { get; set; }
            public double _Lado { get; set; }

            public Area(double _base, double _altura, double _lado)
        {
            _Base = _base;
            _Altura = _altura;
            _Lado = _lado;
        }

        public Area(double @base, double altura)
        {
            this.@base = @base;
            this.altura = altura;
        }

        public Area(double lado)
        {
            this.lado = lado;
        }
    }
}

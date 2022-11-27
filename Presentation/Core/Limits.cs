using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public struct Limits
    {
        public int DoctorsLimits { get; }
        public int CertificatesLimits { get; }
        public int SpecializationsLimits { get; }

        public Limits(int doc, int cerf, int spec)
        {
            DoctorsLimits = doc;
            CertificatesLimits = cerf;
            SpecializationsLimits = spec;
        }

        public override string ToString()
        {
            return $"{DoctorsLimits} : {CertificatesLimits} : {SpecializationsLimits}";
        }
    }
}

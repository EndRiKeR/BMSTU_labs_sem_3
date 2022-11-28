using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public struct Limits
    {
        public List<int> DoctorsLimits { get; }
        public List<int> CertificatesLimits { get; }
        public List<int> SpecializationsLimits { get; }

        public Limits(List<int> doc, List<int> cerf, List<int> spec)
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

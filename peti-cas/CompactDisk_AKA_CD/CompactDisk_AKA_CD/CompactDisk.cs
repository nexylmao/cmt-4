using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompactDisk_AKA_CD
{
    public class CompactDisk
    {
        string naziv;
        string izvodjac;
        DateTime izdat;
        List<string> pesme;

        public string Naziv { get => naziv; }
        public string Izvodjac { get => izvodjac; }
        public DateTime Izdat { get => izdat; }
        public List<string> Pesme { get => pesme; }

        public CompactDisk(string naziv, string izvodjac, DateTime izdat)
        {
            this.naziv = naziv;
            this.izvodjac = izvodjac;
            this.izdat = izdat;
            this.pesme = new List<string>();
        }

        public bool DodajPesmu(string pesma)
        {
            try
            {
                pesme.Add(pesma);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ObrisiPesmu(int index)
        {
            try
            {
                pesme.RemoveAt(index);
                return true;
            } 
            catch
            {
                return false;
            }
        }

        public bool ObrisiPesmu(string pesma)
        {
            try
            {
                pesme.Remove(pesma);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("CompactDisk {");
            builder.AppendLine("\tName : " + this.naziv);
            builder.AppendLine("\tArtist : " + this.izvodjac);
            builder.AppendLine("\tReleased : " + this.izdat.ToUniversalTime());
            if (pesme.Count > 0)
            {
                builder.AppendLine("\tTracks : {");
                for (int i = 0; i < pesme.Count; i++)
                {
                    builder.Append("\t\t" + pesme[i]);
                    if (i + 1 == pesme.Count)
                    {
                        builder.AppendLine();
                    }
                    else
                    {
                        builder.AppendLine(",");
                    }
                }
                builder.AppendLine("\t}");
            }
            builder.AppendLine("}");
            return builder.ToString();
        }
    }
}

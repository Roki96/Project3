using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class BLClassUser
    {
        public string Nickname { get; set; }
        public WherePainted AddWP(Painter Pa, string Pi, int Ya, string Ph, int Va, string Fe, bool Co, string Pe, string cou)
        {
            WherePainted port = new WherePainted();
            port.PainterName = Pa;
            port.PictureName = Pi;
            port.YearCreated = Ya;
            port.Photo = Ph;
            port.Feature = Fe;
            port.Value = Va;
            port.Copy = Co;
            port.People = Pe;
            port.Country = cou;
            return port;
        }
        public FamousPeople AddFP(Painter Pa, string Pi, int Ya, string Ph, int Va, string Fe, bool Co, string Pe, bool cou)
        {
            FamousPeople port = new FamousPeople();
            port.PainterName = Pa;
            port.PictureName = Pi;
            port.YearCreated = Ya;
            port.Photo = Ph;
            port.Feature = Fe;
            port.Value = Va;
            port.Copy = Co;
            port.People = Pe;
            port.Famous = cou;
            return port;
        }
        public Landscape AddLandscape(Painter Pa, string Pi, int Ya, string Ph, int Va, string Fe, bool Co, string Vi)
        {
            Landscape port = new Landscape();
            port.PainterName = Pa;
            port.PictureName = Pi;
            port.YearCreated = Ya;
            port.Photo = Ph;
            port.Feature = Fe;
            port.Value = Va;
            port.Copy = Co;
            port.View = Vi;
            return port;
        }
        public WherePainted Change(string nick, WherePainted port, Painter Pa, string Pi, int Ya, string Ph, int Va, string Fe, bool Co, string Pe, string cou)
        {
            if (Nickname == nick)
            {
                port.PainterName = Pa;
                port.PictureName = Pi;
                port.YearCreated = Ya;
                port.Photo = Ph;
                port.Feature = Fe;
                port.Value = Va;
                port.Copy = Co;
                port.People = Pe;
                port.Country = cou;
            }
            return port;
        }
        public FamousPeople ChangeFP(string nick,FamousPeople port, Painter Pa, string Pi, int Ya, string Ph, int Va, string Fe, bool Co, string Pe, bool cou)
        {
            if (Nickname == nick)
            {
                port.PainterName = Pa;
                port.PictureName = Pi;
                port.YearCreated = Ya;
                port.Photo = Ph;
                port.Feature = Fe;
                port.Value = Va;
                port.Copy = Co;
                port.People = Pe;
                port.Famous = cou;
            }
            return port;
        }
        public Landscape ChangeLandscape(string nick,Landscape port, Painter Pa, string Pi, int Ya, string Ph, int Va, string Fe, bool Co, string Vi)
        {
            if (nick == Nickname)
            {
                port.PainterName = Pa;
                port.PictureName = Pi;
                port.YearCreated = Ya;
                port.Photo = Ph;
                port.Feature = Fe;
                port.Value = Va;
                port.Copy = Co;
                port.View = Vi;
            }
            return port;
        }
    }
}

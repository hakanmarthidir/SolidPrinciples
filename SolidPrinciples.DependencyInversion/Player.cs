using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion
{
    public interface IPlayer
    {
        void Play();
    }

    public class BasketballPlayer : IPlayer
    {
        public void Play()
        {
            throw new NotImplementedException();
        }
    }

    public class FootballPlayer : IPlayer
    {
        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}

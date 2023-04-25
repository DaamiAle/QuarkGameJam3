using QuarkGameJam3.src.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkGameJam3.src.Domain.Entities
{
        public class EmptySpace : GameObject
        {

        public override string Symbol => string.Empty;
        public EmptySpace(Coordinates posicion, Board board) : base(posicion, board) { }

    }
    
}

using System;

namespace tabuleiro
{
    class TabuleiroExcepitoon : Exception
    {
        public TabuleiroExcepitoon( string msg ): base(msg) { }
    }    
}

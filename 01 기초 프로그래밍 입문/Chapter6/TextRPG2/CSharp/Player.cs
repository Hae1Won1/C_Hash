using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public enum PlayerType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3
    }

    class Player : Creature
    {
        // _ 키워드는 이름 규정으로, 멤버변수라는 뜻/개인 호불호긴함
        protected PlayerType _type;

        // 외부에서 함부로 Player를 생성할 수 없도록 선언
        protected Player(PlayerType type) : base(CreatureType.Player)
        {
            this._type = type;
        }
        public PlayerType GetPlayerTyoe() { return _type;  }
 
    }

    class Knight : Player
    {
        // 부모의 생성자 호출
        public Knight() : base(PlayerType.Knight)
        {
            this.SetInfo(100, 10);
        }

    }

    class Archer : Player
    {
        public Archer() : base(PlayerType.Archer)
        { 
            this.SetInfo(75, 13);
        }
    }

    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)
        {
            this.SetInfo(50, 15);
        }
    }
}

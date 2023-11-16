using System.Runtime.CompilerServices;

namespace Program
{        
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SRP 5대 원칙
            //Monster spider = new Monster("독거미", 10, 100);

            //spider.Patrol();

            //Information information = new Information();

            //information.MonsterInfo(spider);
            #endregion

            #region OCP 5대 원칙
            //Marine marine = new Marine();
            //Ghost ghost = new Ghost();
            //Firebet firebet = new Firebet();

            //UnitManager unitManager = new UnitManager();

            //unitManager.Commend(marine);
            //unitManager.Commend(ghost);
            //unitManager.Commend(firebet);
            #endregion

            #region ISP 5대 원칙
            //Wraith wraith = new Wraith();

            //wraith.Attack();
            //wraith.Move();
            //wraith.Skil();

            //BattleCruiser battleCruiser = new BattleCruiser();

            //battleCruiser.Attack();
            //battleCruiser.Move();
            //battleCruiser.Skil();

            //Valkyrie valkyrie = new Valkyrie();

            //valkyrie.Attack();
            //valkyrie.Move();

            //DropShip dropShip = new DropShip();

            //dropShip.Move();
            //dropShip.Skil();
            #endregion

            #region DIP 5대 원칙

            Character character = new Character(100, new Knife());

            character.ChangeWeapon(new Axe());
            character.ChangeWeapon(new Rifle());

            #endregion
        }
    }      
}

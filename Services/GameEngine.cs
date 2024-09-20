using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;
        private readonly IEntity _mage;
        private readonly IEntity _rogue;

        public GameEngine(IEntity character, IEntity goblin, IEntity ghost, IEntity mage, IEntity rogue)
        {
            _character = character;
            _goblin = goblin;
            _ghost = ghost;
            _mage = mage;
            _rogue = rogue;
        }

        public void Run()
        {
            _character.Name = "Hero";
            _goblin.Name = "Goblin";
            _ghost.Name = "Ghost";
            _mage.Name = "Mage";
            _rogue.Name = "Rogue";

            _character.Move();
            _character.Attack(_goblin);

            _goblin.Move();
            _goblin.Attack(_character);
            ((Goblin)_goblin).StealFrom(_character);

            _ghost.Move();
            _ghost.Attack(_character);
            ((Ghost)_ghost).Fly();

            _mage.Move();
            ((Mage)_mage).CastSpell("materialize", _ghost);
            ((Mage)_mage).Fly();
            _mage.Attack(_ghost);

            ((Rogue)_rogue).StealFrom(_goblin);
            _rogue.Move();
            _rogue.Attack(_ghost);
        }
    }
}

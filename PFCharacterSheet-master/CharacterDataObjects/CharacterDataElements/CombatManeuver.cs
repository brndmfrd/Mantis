using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterDataObjects.CharacterDataConstants;

namespace CharacterDataObjects.CharacterDataElements
{
    public class CombatManeuver
    {
        #region Private
        private string CombatManeuverType = string.Empty;
        #endregion Private

        #region Constructor
        public CombatManeuver(string combatManeuverType)
        {
            CombatManeuverType = combatManeuverType;
        }
        #endregion Constructor

        #region Public Methods
        public int GetCombatManeuverValue()
        {
            int retval = -1;

            //if (CombatManeuverType == Constants.CMB)
            //{
            //    retval = MyConnections.Bab;
            //    retval += MyConnections.AbilityScores[Constants.Strength].Value;
            //    retval += MyConnections.Size.SizeModifier;
            //}

            //if (CombatManeuverType == Constants.CMD)
            //{
            //    retval = 10;
            //    retval += MyConnections.Bab;
            //    retval += MyConnections.AbilityScores[Constants.Strength].Value;
            //    retval += MyConnections.AbilityScores[Constants.Dexterity].Value;
            //    retval += MyConnections.Size.SizeModifier;
            //}

            return retval;
        }
        #endregion PublicMethods


    }
}

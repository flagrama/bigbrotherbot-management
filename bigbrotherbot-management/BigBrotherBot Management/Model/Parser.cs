/*  Copyright (C) 2014  Vincent Cunningham

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA. */

using System.Collections.Generic;

namespace BigBrotherBot_Management.Model
{
    public static class Parser
    {
        private static Dictionary<string, string> _parserDictionary = new Dictionary<string, string>
        {
            {"altitude", "Altitude"},
            {"arma2", "ArmA II / DayZ"},
            {"arma3", "ArmA III"},
            {"bf3", "Battlefield 3"},
            {"bf4", "Battlefield 4"},
            {"bfbc2", "Battlefield Bad Company 2"},
            {"cod", "Call of Duty"},
            {"cod2", "Call of Duty 2"},
            {"cod4", "Call of Duty 4"},
            {"cod7", "Call of Duty: Black Ops"},
            {"cod6", "Call of Duty: Modern Warfare 2"},
            {"cod5", "Call of Duty: World at War"},
            {"chiv", "Chivalry Medieval Warfare"},
            {"csgo", "Counter-Strike: Global Offensive"},
            {"frontline", "Frontlines: Fuel of War"},
            {"homefront", "Homefront"},
            {"moh", "Medal of Honor"},
            {"oa081", "Open Arena"},
            {"ravaged", "Ravaged"},
            {"ro2", "Red Orchestra 2"},
            {"smg11", "Smokin' Guns"},
            {"iourt41", "Urban Terror 4.1"},
            {"iourt42", "Urban Terror 4.2"},
            {"etpro", "Wolfenstein Enemy Territory"},
            {"wop", "World of Padman"}
        };

        public static Dictionary<string, string> ParserDictionary
        {
            set { _parserDictionary = value; }
            get { return _parserDictionary; }
        }
    }
}
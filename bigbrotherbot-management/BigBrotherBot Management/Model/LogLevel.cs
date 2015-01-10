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
    public static class LogLevel
    {
        private static Dictionary<string, int> _logLevelDictionary = new Dictionary<string, int>
        {
            {"8", 0},
            {"9", 1},
            {"10", 2},
            {"20", 3},
            {"21", 4},
            {"22", 5},
            {"30", 6},
            {"40", 7},
            {"50", 8}
        };

        public static Dictionary<string, int> LogLevelDictionary
        {
            set { _logLevelDictionary = value; }
            get { return _logLevelDictionary; }
        }
    }
}
/*
 This file is part of the MapleStory Unity

 Copyright (C) 2021-2022 Shen, Jen-Chieh <jcs090218@gmail.com> 

 This program is free software: you can redistribute it and/or modify
 it under the terms of the GNU Affero General Public License version 3
 as published by the Free Software Foundation. You may not use, modify
 or distribute this program under any other version of the
 GNU Affero General Public License.

 This program is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 GNU Affero General Public License for more details.

 You should have received a copy of the GNU Affero General Public License
 along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace MSU
{
    /// <summary>
    /// Utility class.
    /// </summary>
    public static class Util
    {
        /* Variables */

        /* Setter & Getter */

        /* Functions */

        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
    }
}

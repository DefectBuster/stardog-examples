﻿/*
 * Copyright (c) 2010 - 2019, Stardog Union. <http://www.stardog.com>
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using example;
using Semiodesk.Trinity;
using System;
using System.Collections.Generic;

namespace TrinityConsoleSample.ObjectModels
{
    /// <summary>
    /// A music group; that is, is a group of people creating and performing music together.
    /// </summary>
    [RdfClass(MUSIC.Band)]
    class Band : Artist
    {
        #region Members

        /// <summary>
        /// A member of a band. Does not distinguish between past vs current members
        /// </summary>
        [RdfProperty(MUSIC.member)]
        public List<SoloArtist> Members { get; set; }

        #endregion

        #region Constructors

        public Band(Uri uri) : base(uri) { }

        #endregion

    }
}
﻿// Copyright 2015 ACENSI http://www.acensi.fr/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;
using System.Linq;

namespace VarProcess.Utilities
{
    public static class Helpers
    {
        public static IList<double> SumList(IList<double> firsts, IList<double> seconds)
        {
            return firsts.Count == 0 ? seconds : Enumerable.Range(0, seconds.Count).Select(i => firsts[i] + seconds[i]).ToList();
        }
    }
}

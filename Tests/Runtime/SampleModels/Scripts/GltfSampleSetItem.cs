// Copyright 2020-2021 Andreas Atteneder
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System;
using System.IO;

namespace GLTFast.Tests {

    [Serializable]
    public struct GltfSampleSetItem {
        public string name;
        public string path;

        public GltfSampleSetItem(string name, string path) {
            this.name = name;
            this.path = path;
        }

        public string[] directoryParts {
            get { return Path.GetDirectoryName(path).Split(Path.DirectorySeparatorChar); }
        }
    }
}

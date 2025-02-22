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

using UnityEngine;

namespace GLTFast.Export {
    
    /// <summary>
    /// glTF format
    /// </summary>
    public enum GltfFormat {
        /// <summary>
        /// JSON-based glTF (.gltf file extension)
        /// </summary>
        Json,
        /// <summary>
        /// glTF-binary (.glb file extension)
        /// </summary>
        Binary
    }
    
    /// <summary>
    /// Destination for image files
    /// </summary>
    public enum ImageDestination {
        /// <summary>
        /// Automatic decision. Main buffer for glTF-binary, separate files for JSON-based glTFs.
        /// </summary>
        Automatic,
        /// <summary>
        /// Embeds images in main buffer
        /// </summary>
        MainBuffer,
        /// <summary>
        /// Saves images as separate files relative to glTF file
        /// </summary>
        SeparateFile
    }

    public enum FileConflictResolution {
        Abort,
        Overwrite
    }
    
    /// <summary>
    /// glTF export settings
    /// </summary>
    public class ExportSettings {
        public GltfFormat format = GltfFormat.Json;
        public ImageDestination imageDestination = ImageDestination.Automatic;
        public FileConflictResolution fileConflictResolution = FileConflictResolution.Abort;
    }
}

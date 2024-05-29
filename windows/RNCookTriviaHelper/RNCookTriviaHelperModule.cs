using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Cook.Trivia.Helper.RNCookTriviaHelper
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNCookTriviaHelperModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNCookTriviaHelperModule"/>.
        /// </summary>
        internal RNCookTriviaHelperModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNCookTriviaHelper";
            }
        }
    }
}

using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Dancer.Fans.Gz.Activity.RNDancerFansGzActivity
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNDancerFansGzActivityModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNDancerFansGzActivityModule"/>.
        /// </summary>
        internal RNDancerFansGzActivityModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNDancerFansGzActivity";
            }
        }
    }
}

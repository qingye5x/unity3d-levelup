// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;

namespace Soomla.Levelup
{
	public class ActionMission
		{
		public string IconUrl;
		
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="rewardId">see parent</param>
		/// <param name="name">see parent</param>
		public BadgeReward(string rewardId, string name)
			: base(rewardId, name)
		{
		}
		
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="rewardId">see parent</param>
		/// <param name="name">see parent</param>
		/// <param name="iconUrl">A url to the icon of this Badge on the device.</param>
		public BadgeReward(string rewardId, string name, string iconUrl)
			: base(rewardId, name)
		{
			IconUrl = iconUrl;
		}
		
		/// <summary>
		/// see parent.
		/// </summary>
		public BadgeReward(JSONObject jsonReward)
			: base(jsonReward)
		{
			IconUrl = jsonReward[JSONConsts.SOOM_REWARD_ICONURL].str;
		}
		
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <returns>see parent</returns>
		public override JSONObject toJSONObject() {
			JSONObject obj = base.toJSONObject();
			obj.AddField(JSONConsts.SOOM_REWARD_ICONURL, IconUrl);
			obj.AddField(JSONConsts.SOOM_CLASSNAME, GetType().Name);
			
			
			return obj;
		}
	}
}


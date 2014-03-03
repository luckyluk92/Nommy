//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;

namespace Assets.Utils.PowerCommand
{
		public class BubbleJumpPowerCommand: ICommand
		{
			private CharacterController2D CC2D;

			/// <summary>
			/// Creates the Bubble Jump Power Command
			/// </summary>
			/// <param name="PowerUser">Object which uses the power</param>
			public BubbleJumpPowerCommand (GameObject PowerUser)
			{
				CC2D = PowerUser.GetComponent<CharacterController2D>();				
			}

			#region ICommand implementation

			public void Execute ()
			{
				CC2D.velocity += new Vector3(0, 0.8f);//sample
			}
			
			#endregion
		}
}


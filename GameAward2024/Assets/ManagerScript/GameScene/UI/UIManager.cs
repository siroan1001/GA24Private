using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene
{
	public class UIManager : ManagerBase
	{
		[SerializeField]
		PlayerGaugeController m_playerGaugeController;
		/// <summary>
		/// PlayerGaugeControllerを取得
		/// </summary>
		public PlayerGaugeController playerGaugeController => m_playerGaugeController;

		[SerializeField]
		TimeGaugeController m_timeGaugeController;
		/// <summary>
		/// TimeGaugeControllerを取得
		/// </summary>
		public TimeGaugeController timeGaugeController => m_timeGaugeController;
	}
}
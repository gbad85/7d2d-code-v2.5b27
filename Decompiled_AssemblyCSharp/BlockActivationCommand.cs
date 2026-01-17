using System;
using UnityEngine;

public struct BlockActivationCommand
{
	public string text;

	public string icon;

	public Color iconColor;

	public bool enabled;

	public bool highlighted;

	public string eventName;

	public float activateTime;

	public static readonly BlockActivationCommand[] Empty = Array.Empty<BlockActivationCommand>();

	public BlockActivationCommand(string _text, string _icon, bool _enabled, bool _highlighted = false, string _eventName = null)
	{
		text = _text;
		icon = _icon;
		enabled = _enabled;
		highlighted = _highlighted;
		eventName = _eventName;
		iconColor = Color.white;
		activateTime = -1f;
	}
}

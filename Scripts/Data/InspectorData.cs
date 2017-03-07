﻿#if UNITY_EDITOR
using ListView;
using System.Collections.Generic;

namespace UnityEditor.Experimental.EditorVR.Data
{

	class InspectorData : ListViewItemNestedData<InspectorData>
	{
#if UNITY_EDITOR
		public SerializedObject serializedObject { get; private set; }

		public virtual int? instanceID
		{
			get
			{
				if (serializedObject == null || serializedObject.targetObject == null)
					return null;

				return serializedObject.targetObject.GetInstanceID();
			}
		}

		public InspectorData(string template, SerializedObject serializedObject, List<InspectorData> children)
		{
			this.template = template;
			this.serializedObject = serializedObject;
			m_Children = children;
		}
#endif
	}
}
#endif

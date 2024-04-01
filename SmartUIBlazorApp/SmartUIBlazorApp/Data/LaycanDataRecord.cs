using System.Text.Json.Serialization;

namespace SmartUIBlazorApp
{
    public partial class LaycanDataRecord
    {
        [JsonPropertyName("id")]
        public string Id
        {
            get;
            set;
        }

        [JsonPropertyName("label")]
        public string Label
        {
            get;
            set;
        }
        [JsonPropertyName("dateStart")]
        public string DateStart
        {
            get; set;
        }

        [JsonPropertyName("dateEnd")]
        public string DateEnd
        {
            get; set;
        }

        [JsonPropertyName("class")]
        public string Class
        {
            get; set;
        }

        [JsonPropertyName("type")]
        public string Type
        {
            get; set;
        }

        [JsonPropertyName("progress")]
        public int Progress
        {
            get; set;
        }

        [JsonPropertyName("duration")]
        public int Duration
        {
            get; set;
        }

        [JsonPropertyName("synchronized")]
        public bool Synchronized
        {
            get; set;
        }

        [JsonPropertyName("expanded")]
        public bool Expanded
        {
            get; set;
        }

        [JsonPropertyName("tasks")]
        public List<LaycanDataRecord> Tasks
        {
            get; set;
        }

        [JsonPropertyName("disableResources")]
        public bool DisableResources
        {
            get; set;
        }

        [JsonPropertyName("resources")]
        public object Resources
        {
            get; set;
        } = new object[] { };

        [JsonPropertyName("planned")]
        public object Planned
        {
            get;
            set;
        } = new object[] { };

        [JsonPropertyName("connections")]
        public List<Dictionary<string, int>> Connections
        {
            get; set;
        } = new List<Dictionary<string, int>>() { };

        [JsonPropertyName("disableDrag")]
        public bool DisableDrag
        {
            get; set;
        }

        [JsonPropertyName("disableResize")]
        public bool DisableResize
        {
            get; set;
        }

        [JsonPropertyName("minDateStart")]
        public string MinDateStart
        {
            get; set;
        }

        [JsonPropertyName("maxDateStart")]
        public string MaxDateStart
        {
            get; set;
        }

        [JsonPropertyName("minDateEnd")]
        public string MinDateEnd
        {
            get; set;
        }

        [JsonPropertyName("maxDateEnd")]
        public string MaxDateEnd
        {
            get; set;
        }

        [JsonPropertyName("minDuration")]
        public int MinDuration
        {
            get; set;
        }

        [JsonPropertyName("maxDuration")]
        public int MaxDuration
        {
            get; set;
        }

        [JsonPropertyName("value")]
        public int Value
        {
            get; set;
        }

        [JsonPropertyName("dragProject")]
        public bool DragProject
        {
            get; set;
        }

    }
}

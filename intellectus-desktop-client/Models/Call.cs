using EmotionRecognition.Wrapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace intellectus_desktop_client.Models
{
    public class Call
    {
        public Call() { }
        
        [JsonProperty("startTime")]
        public DateTime StartTime { get; set; }

        [JsonProperty("endTime")]
        public DateTime EndTime { get; set; }

        [JsonProperty("emotion")]
        public string Emotion { get; set; }

        [JsonProperty("operatorStats")]
        public EmotionsProbabilities OperatorStats { get; set; }

        [JsonProperty("consultantStats")]
        public EmotionsProbabilities ConsultantStats { get; set; }

        [JsonProperty("callId")]
        public int Id { get; set; }


    }
}

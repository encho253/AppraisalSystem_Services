using DB;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Interfaces.DTO.Response
{
    [Serializable]
    [DataContract]
    public class CompetenceDto
    {
        public CompetenceDto(Competence competence)
        {
            this.Id = competence.Id;
            this.Key = competence.Key;
        }

        List<Question> _questions = new List<Question>();

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Key { get; set; }

        [DataMember]
        public int QuestionsCount { get; set; }

        [DataMember]
        public IEnumerable<Question> Questions { get; set; }
    }
}
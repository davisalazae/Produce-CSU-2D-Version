using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
namespace ProduceCSU
{
    public interface ISkillLevel
    {
        //private float danceSkill, singingSkill, modelingSkill, groupLevel, energy;
        float DanceSkill { get; set; }
        float SingingSkill { get; set; }
        float ModelingSkill { get; set; }
        float GroupLevel { get; set; }
        float Energy { get; set; }
        void AddDecorator(ISkillLevel decorator);
    }
    public class SkillLevel : ISkillLevel
    {
        private float _danceSkill;
        public float DanceSkill
        {
            get
            {
                if (_decorator == null)
                {
                    return _danceSkill;
                }
                else
                {
                    return _danceSkill + _decorator.DanceSkill;
                }

            }
            set
            {
                _danceSkill = value;
            }
        }

        private float _singingSkill;
        public float SingingSkill
        {
            get
            {
                if (_decorator == null)
                {
                    return _singingSkill;
                }
                else
                {
                    return _singingSkill + _decorator.SingingSkill;
                }

            }
            set
            {
                _singingSkill = value;
            }
        }

        private float _modelingSkill;
        public float ModelingSkill
        {
            get
            {
                if (_decorator == null)
                {
                    return _modelingSkill;
                }
                else
                {
                    return _modelingSkill + _decorator.ModelingSkill;
                }

            }
            set
            {
                _modelingSkill = value;
            }
        }

        private float _groupLevel;
        public float GroupLevel
        {
            get
            {
                if (_decorator == null)

                    return _groupLevel;
                else
                {
                    return _groupLevel + _decorator.GroupLevel;

                }
            }

            set
            {
                _groupLevel = value;
                if (_groupLevel > 5)
                {
                    _groupLevel = 5;
                }
            }
        }
        private float _energy;
        public float Energy
        {
            get
            {
                if (_decorator == null)
                {
                    return _energy;
                }
                else
                {
                    return _energy + _decorator.Energy;
                }

            }
            set
            {
                _energy = value;
                if (_energy > 5)
                {
                    _energy = 5;
                }

            }
        }
        private ISkillLevel _decorator;
        public SkillLevel() : this(0.0f, 0.0f, 0.0f, 0.0f, 5.0f)
        {

        }

        public SkillLevel(float danceSkill, float singingSkill, float modelingSkill, float groupLevel, float energyLevel)
        {
            DanceSkill = danceSkill;
            SingingSkill = singingSkill;
            ModelingSkill = modelingSkill;
            GroupLevel = groupLevel;
            Energy = energyLevel;
            _decorator = null;
        }
        public void AddDecorator(ISkillLevel decorator)
        {
            if (_decorator == null)
            {
                _decorator = decorator;
            }
            else
            {
                _decorator.AddDecorator(decorator);
            }
        }
    }
}


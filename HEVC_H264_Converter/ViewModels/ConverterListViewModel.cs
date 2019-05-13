﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HEVC_H264_Converter.Model;
using Microsoft.Toolkit.Uwp.Helpers;

namespace HEVC_H264_Converter.ViewModels
{
    class ConverterListViewModel : BindableBase, IEditableObject
    {

        public ConverterListViewModel(HevcFile model = null) => Model = model ?? new HevcFile();


        private HevcFile _model;
        public HevcFile Model
        {
            get => _model;
            set
            {
                if (_model != value)
                {
                    _model = value;
                    OnPropertyChanged(string.Empty);
                }
            }
        }

        public string FileName
        {
            get => Model.FileName;
            set
            {
                if (value != Model.FileName)
                {
                    Model.FileName = value;
                    IsModified = true;
                    OnPropertyChanged();
                }
            }
        }

        public string FilePath
        {
            get => Model.FilePath;
            set
            {
                if (value != Model.FilePath)
                {
                    Model.FilePath = value;
                    IsModified = true;
                    OnPropertyChanged();
                }
            }
        }

        public string Percentage
        {
            get => Model.Percentage.ToString();
            set
            {
                if (value != Model.Percentage.ToString())
                {
                    Model.Percentage = System.Convert.ToInt32(value);
                    IsModified = true;
                    OnPropertyChanged();
                }
            }
        }

        public string Speed
        {
            get => Model.Speed.ToString();
            set
            {
                if (value != Model.Speed.ToString())
                {
                    Model.Speed = Convert.ToInt32(value);
                    IsModified = true;
                    OnPropertyChanged();
                }
            }
        }

        public string TargetPath
        {
            get => Model.TargetPath;
            set
            {
                if (value != Model.TargetPath)
                {
                    Model.TargetPath = value;
                    IsModified = true;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsFinished
        {
            get => Model.IsFinished;
            set
            {
                if (value != Model.IsFinished)
                {
                    Model.IsFinished = value;
                    IsModified = true;
                    OnPropertyChanged();
                }
            }
        }

        public List<HevcFile> Files
        {
            get;set;
        }



        public bool IsModified { get; set; }

        public void BeginEdit()
        {

        }

        public void CancelEdit()
        {
        }

        public void EndEdit()
        {

        }
    }
}

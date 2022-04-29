﻿using UnityEngine;

namespace Dummy
{
    public class ItemSetup : MonoBehaviour
    {
        [SerializeField] private ItemView _view;
        [SerializeField] private DummyMainView _mainView;
        [SerializeField] private ItemModel _model;
        private ItemPresenter _presenter;

        private void Awake()
        {
            _presenter = new ItemPresenter(_view, _mainView, _model);
            _model.Init();

            if (_model.ItemImage == null)
            {
                _view.ButtonImage.gameObject.SetActive(false);
            }
            else
            {
                _view.SetButtonShape(_model.ItemImage);
                _view.EnableItemObject(_model.ItemImage);
            }
        }

        private void OnEnable()
        {
            _presenter.Enable();
        }

        private void OnDisable()
        {
            _presenter.Disable();
        }
    }
}
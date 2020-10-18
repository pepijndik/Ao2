<?php
defined('BASEPATH') or exit('No direct script access allowed');

class Customer extends Admin_Controller
{
        public function __construct()
        {
                //Hoofd cclass construct
                parent::__construct();

                //als niet ingelogd
                $this->not_logged_in();

                //Pagina titel
                $this->data['page_title'] = 'uitgifte';

                /* Laad model */
                $this->load->model('model_uitgifte');
                $this->load->model('model_products');
                $this->load->model('model_company');
        
        }

}

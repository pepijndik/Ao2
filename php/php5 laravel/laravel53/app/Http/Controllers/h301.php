<?php

namespace App\Http\Controllers;

use App\User;
use App\Http\Controllers\Controller;

class H301 extends Controller
{

    public function geefopdracht()
    {
        return view('opdracht1', ['name' => 'pepijn']);
    }

    public function opdracht4($name)
    {
        return view('opdracht2', ['name' => $name]);
    }
}

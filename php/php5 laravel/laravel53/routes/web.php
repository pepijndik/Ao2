<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

//use Illuminate\Routing\Route;
use Illuminate\Support\Facades\Route;

Route::get('/', function () {
    echo "Dit is mijn eerste webpagina in Laravel";
    //return view('welcome');
});
Route::get('overzicht', function () {
    echo "Op deze pagina komt een overzicht van postartikelen";
    //return view('welcome');
});
Route::get('invoer', function () {
    echo "Op deze pagina komt een invoerformulier voor postartikelen";
    //return view('welcome');
});
Route::get('overzicht/{name}', function ($name) {
    echo "Het eerst artikel is afkomstig van " . $name;
    //return view('welcome');
});

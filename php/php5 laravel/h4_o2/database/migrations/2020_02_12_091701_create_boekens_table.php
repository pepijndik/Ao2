<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateBoekensTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('boekens', function (Blueprint $table) {
            $table->bigIncrements('id');
            $table->timestamps();
            $table->increments('boeknummer', 10);
            $table->integer('isbn', 13);
            $table->string('titel', 15);
            $table->string('ondertitel', 15);
            $table->string('omschrijving', 200);
            $table->double('prijs', 10);
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('boekens');
    }
}

<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;
use PhpParser\Node\Expr\Cast\Double;

class CreateArtikelsTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('artikels', function (Blueprint $table) {
            $table->bigIncrements('id');
            $table->timestamps();
            $table->increments('artikelnummer', 10);
            $table->string('artikelnaam', 15);
            $table->string('artikelomschrijving', 200);
            $table->double('artikelprijs', 10);
            //             artikelnummer (integer, autoincrement en 10 tekens)
            // artikelnaam (string en maximaal 15 tekens)
            // artikelomschrijving (string en maximaal 200 tekens)
            // artikelprijs (double en in totaal maximaal 10 tekens)
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('artikels');
    }
}

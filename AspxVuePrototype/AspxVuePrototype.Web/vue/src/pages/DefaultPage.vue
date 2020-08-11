<template>

  <div id="DefaultPage">

    <h1>Default page - Vue.JS</h1>
    <hr>
    <hr>


    <div>
      <b-button v-b-modal.modal-1>Launch demo modal</b-button>

      <b-modal id="modal-1" title="BootstrapVue">

        Modal 1

        <b-button v-b-modal.modal-2>Launch demo modal</b-button>

        <b-modal id="modal-2" title="BootstrapVue 2">

          Modal 2

        </b-modal>



      </b-modal>
    </div>


    <hr>
    <hr>

    <PersonTable></PersonTable>

    <a class="btn btn-primary" v-on:click="getPerson">Person console</a>

    <FullNameEditor v-model="fullName"></FullNameEditor>

    <RefreshButton></RefreshButton>


  </div>

</template>


<script>

// import FullNameEditor from "../components/FullNameEditor";

import RefreshButton from "../components/refresh-button/RefreshButton";
import FullNameEditor from "../components/FullNameEditor";
import PersonTable from "../components/PersonTable";
import PersonService from "../services/person.service";

export default {
  name: 'DefaultPage',
  components: {
    FullNameEditor,
    RefreshButton,
    PersonTable
  },
  props: {
    msg: String
  },
  data() {
    return {
      fullName: 'Riki Fridrich'
    }
  },
  methods: {
    getPerson: function () {
      let a = new PersonService().getPersons();
      console.log(a);
    }
  }
};

</script>

<style scoped>

</style>

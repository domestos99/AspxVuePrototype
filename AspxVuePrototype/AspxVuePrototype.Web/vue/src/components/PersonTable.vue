<template>
  <div>

    <YesNoModal v-if="showModal" id="bv-modal-example"
                @close="showModal = false"
                @yesClick="showModal = false"
                @noClick="showModal = false"
          ></YesNoModal>


    <button v-on:click="openModal">Open modal</button>

    <div v-if="loading" class="loading">
      Loading...
    </div>

    <div v-if="error" class="error">
      {{ error }}
    </div>

    <RefreshButton v-on:refreshClick="fetchData"></RefreshButton>

    <div v-if="personData" class="content">
      <table class="table table-bordered table-striped">
        <thead>
        <tr>
          <th>

            <a href="javascript:;" v-on:click="orderColumn('Id')">ID
              <span v-bind:class="[orderAsc ? 'fa fa-caret-up' : 'fa fa-caret-down', orderBy === 'Id' ? 'visible' : 'd-none']"
              ></span>
            </a>

            <!--          <a href="javascript:;" data-bind="click: function () { orderAsc(!orderAsc()); orderBy('ID'); search() }">ID -->
            <!--            <span data-bind="css: orderAsc() ? 'fa fa-caret-up' : 'fa fa-caret-down', visible: orderBy() == 'ID' ? true : false"></span></a></th>-->


          </th>
          <th>

            <a href="javascript:;" v-on:click="orderColumn('Name')">Name
              <span v-bind:class="[orderAsc ? 'fa fa-caret-up' : 'fa fa-caret-down', orderBy === 'Name' ? 'visible' : 'd-none']"
              ></span>
            </a>

          </th>
        </tr>
        </thead>
        <tbody>

        <tr v-for="(per, i) in personData" v-bind:key="i">
          <td>{{ per.Id }}</td>
          <td>{{ per.Name }}</td>
        </tr>
        </tbody>
      </table>

      <Pagination></Pagination>



    </div>
  </div>

</template>

<script>


import Pagination from "@/components/Pagination";
import RefreshButton from "./RefreshButton";
import YesNoModal from "./YesNoModal";

const $ = require('jquery');

export default {

  name: 'PersonTable',
  components:{
    YesNoModal,
    Pagination,
    RefreshButton
  },
  data() {
    return {
      loading: false,
      personData: [],
      error: null,
      orderBy: 'Id',
      orderAsc: true,
      showModal: false
    }
  },
  mounted() {
    // fetch the data when the view is created and the data is
    // already being observed
    this.fetchData();
  },
  watch: {
    // call again the method if the route changes
    // '$route': 'fetchData'
  },
  methods:
      {
        fetchData() {
          const self = this;
          self.loading = true;
          self.error = null;
          $.post('/services/TestHandler.ashx',
              {
                action: 'test',
                orderBy: self.orderBy,
                orderAsc: self.orderAsc
              },
              function (data) {
                self.loading = false;
                if (data.Success) {
                  console.log(data.Data);
                  self.personData = data.Data;
                  console.log(this.personData);
                } else {
                  self.error = data.Message;
                  console.log(data.Message);
                }
              });

        },
        orderColumn(key) {
          this.orderAsc = !this.orderAsc;
          this.orderBy = key;
          this.fetchData();
        },
        openModal(){
          // this.$bvModal.show('bv-modal-example');
          this.showModal = true;
        }
      },


}
</script>

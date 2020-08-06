<template>
  <div>

    <a href="javascript:;" class="btn btn-default" v-on:click="fetchData">Load data</a>

    <div v-if="loading" class="loading">
      Loading...
    </div>

    <div v-if="error" class="error">
      {{ error }}
    </div>

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

const $ = require('jquery');

export default {

  name: 'PersonTable',
  components:{
    Pagination,
  },
  data() {
    return {
      loading: false,
      personData: [],
      error: null,
      orderBy: 'Id',
      orderAsc: true
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
          this.loading = true;
          this.error = null;
          const self = this;
          $.post('/services/TestHandler.ashx',
              {
                action: 'test',
                orderBy: self.orderBy,
                orderAsc: self.orderAsc
              },
              function (data) {
                this.loading = false;
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
      },


}
</script>

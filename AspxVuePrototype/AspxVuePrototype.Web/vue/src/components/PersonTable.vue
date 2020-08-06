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
          <th>Id</th>
          <th>Name</th>
        </tr>
        </thead>
        <tbody>

        <tr v-for="(per, i) in personData" v-bind:key="i">
          <td>{{ per.Id }}</td>
          <td>{{ per.Name }}</td>
        </tr>
        </tbody>
      </table>
    </div>
  </div>
</template>

<script>


const $ = require('jquery');

export default {

  name: 'PersonTable',
  data() {
    return {
      loading: false,
      personData: [],
      error: null
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
                action: 'test'
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

        }
      },


}
</script>

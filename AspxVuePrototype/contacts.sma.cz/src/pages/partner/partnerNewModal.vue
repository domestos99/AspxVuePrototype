<template>
  <div class="form-horizontal">

    <div class="row">
      <div class="col-sm-6">
        <div class="form-group">
          <label for="inputNewName" class="col-sm-3 control-label">Jméno</label>
          <input id="inputNewName" type="text" v-model="newName" placeholder="Jméno..." class="form-control" />
        </div>
      </div>
    </div>

  </div>
</template>

<script>
export default {
  name: 'partnerNewModal',
  data() {
    return {
      newName: ''
    };
  },
  methods: {}

}
</script>

<style scoped>

</style>

<template>

  <div>
    <a href="javascript:;"
       class="btn btn-default"
       v-on:click="onRefreshClick"><span class="fa fa-sync"></span>
    &nbsp;Aktualizovat</a>
  </div>

</template>

<script>

export default {

  name: 'RefreshButton',
  methods:{
    onRefreshClick() {
      this.$emit('refreshClick');
    }
  }
}


</script>
